using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace BiochimAnaliz
{
    public partial class StartForm : Form
    {
        BiochemicalAnalysisOfUrineLimits analysisOfUrineLimits = new();

        public StartForm()
        {
            InitializeComponent();
            SetSettingsDateTimePicker();
            SetVariablesForGender();
        }

        public void SetSettingsDateTimePicker()
        {
            dtpDOB.MaxDate = DateTime.Today;
            dtpDOB.Value = dtpDOB.MinDate;
        }

        public void SetVariablesForGender()
        {
            cbGender.Items.Add("Жіноча");
            cbGender.Items.Add("Чоловіча");
        }

        private void SetGender(object sender, EventArgs e)
        {
            cbPregnancy.Visible = cbGender.SelectedIndex == 0;
        }

        private void ClearForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете виконати цю дію?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearFields();
            }
        }

        private void ImportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new()
                {
                    FilterIndex = 0,
                    RestoreDirectory = true,
                    Filter = "JSON Files|*.json"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog.FileName;
                    var incoming = new List<BiochemicalAnalysisOfUrine>();

                    using StreamReader r = new(selectedFileName);
                    string json = r.ReadToEnd();
                    BiochemicalAnalysisOfUrine bioAnalOfUrin = JsonConvert.DeserializeObject<BiochemicalAnalysisOfUrine>(json);

                    tbFullName.Text = bioAnalOfUrin.FullName.ToString();
                    cbGender.Text = bioAnalOfUrin.Gender.ToString();
                    dtpDOB.Value = bioAnalOfUrin.DOB;
                    cbPregnancy.Checked = bioAnalOfUrin.Pregnancy;
                    tbPH.Text = bioAnalOfUrin.PH.ToString();
                    tbGlucose.Text = bioAnalOfUrin.Glucose.ToString();
                    tbAlbumen.Text = bioAnalOfUrin.Albumen.ToString();
                    tbKetones.Text = bioAnalOfUrin.Ketones.ToString();
                    tbNitrite.Text = bioAnalOfUrin.Nitrite.ToString();
                    tbUrobilinogen.Text = bioAnalOfUrin.Urobilinogen.ToString();
                    tbCreatinine.Text = bioAnalOfUrin.Creatinine.ToString();
                    tbSodium.Text = bioAnalOfUrin.ElectrolytesSodium.ToString();
                    tbPotassium.Text = bioAnalOfUrin.ElectrolytesPotassium.ToString();
                    tbChlorides.Text = bioAnalOfUrin.ElectrolytesChlorides.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Відбулася непередбачена помилка. Зверніться до адміністратора!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ExportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == true)
            {
                try
                {
                    BiochemicalAnalysisOfUrine bioAnalOfUrin = new()
                    {
                        FullName = tbFullName.Text,
                        Gender = cbGender.Text,
                        DOB = dtpDOB.Value,
                        Pregnancy = cbPregnancy.Checked,
                        PH = double.Parse(tbPH.Text),
                        Glucose = double.Parse(tbGlucose.Text),
                        Albumen = double.Parse(tbAlbumen.Text),
                        Ketones = double.Parse(tbKetones.Text),
                        Nitrite = double.Parse(tbNitrite.Text),
                        Urobilinogen = double.Parse(tbUrobilinogen.Text),
                        Creatinine = double.Parse(tbCreatinine.Text),
                        ElectrolytesSodium = double.Parse(tbSodium.Text),
                        ElectrolytesPotassium = double.Parse(tbPotassium.Text),
                        ElectrolytesChlorides = double.Parse(tbChlorides.Text)
                    };

                    string json = JsonConvert.SerializeObject(bioAnalOfUrin);

                    string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $@"/Patient/JSON/{DateTime.Now:ddMMyyyy}/";
                    string fileName = tbFullName.Text + $@" {DateTime.Now:ddMMyyyy}.json";

                    if (!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }

                    File.WriteAllText(filePath + fileName, json);
                    MessageBox.Show("Створенно файл" + $@"{fileName}", "Експорт виконано", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Відбулася непередбачена помилка. Зверніться до адміністратора!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void ParametersForAnalysis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }
        }


        private bool ValidateFields()
        {
            bool isValid = true;
            List<Control> emptyFields = new();

            if (string.IsNullOrEmpty(tbFullName.Text))
            {
                emptyFields.Add(lbFullName);
                lbFullName.ForeColor = Color.Red;
                isValid = false;
            }

            if (cbGender.SelectedItem == null)
            {
                emptyFields.Add(lbGender);
                lbGender.ForeColor = Color.Red;
                isValid = false;
            }

            if (dtpDOB.Value <= dtpDOB.MinDate)
            {
                emptyFields.Add(lbDOB);
                lbDOB.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbPH.Text))
            {
                emptyFields.Add(lbPH);
                lbPH.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbGlucose.Text))
            {
                emptyFields.Add(lbGlucose);
                lbGlucose.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbAlbumen.Text))
            {
                emptyFields.Add(lbAlbumen);
                lbAlbumen.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbKetones.Text))
            {
                emptyFields.Add(lbKetones);
                lbKetones.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbNitrite.Text))
            {
                emptyFields.Add(lbNitrite);
                lbNitrite.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbUrobilinogen.Text))
            {
                emptyFields.Add(lbUrobilinogen);
                lbUrobilinogen.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbCreatinine.Text))
            {
                emptyFields.Add(lbCreatinine);
                lbCreatinine.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbSodium.Text))
            {
                emptyFields.Add(lbSodium);
                lbSodium.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbPotassium.Text))
            {
                emptyFields.Add(lbPotassium);
                lbPotassium.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrEmpty(tbChlorides.Text))
            {
                emptyFields.Add(lbChlorides);
                lbChlorides.ForeColor = Color.Red;
                isValid = false;
            }

            if (lbPotassium.ForeColor == Color.Red || lbSodium.ForeColor == Color.Red || lbChlorides.ForeColor == Color.Red)
            {
                gbElectrolytes.ForeColor = Color.Red;
            }

            if (!isValid)
            {
                string errorMessage = "Заповніть наступні поля:\n\n";
                foreach (Control field in emptyFields)
                {
                    if (field.Text == lbSodium.Text || field.Text == lbPotassium.Text || field.Text == lbChlorides.Text)
                    {
                        errorMessage += gbElectrolytes.Text + ' ' + field.Text.ToLower() + "\n";
                    }
                    else
                    {
                        errorMessage += field.Text + "\n";
                    }
                }
                MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string controlNameLabel;
            if (sender is DateTimePicker)
            {
                string controlNameBox = control.Name.Substring(3);
                controlNameLabel = "lb" + controlNameBox;
            }
            else
            {
                string controlNameBox = control.Name.Substring(2);
                controlNameLabel = "lb" + controlNameBox;
            }

            Label label = Controls.Find(controlNameLabel, true).FirstOrDefault() as Label;
            label.ForeColor = Color.Black;

            if (lbPotassium.ForeColor != Color.Red && lbSodium.ForeColor != Color.Red && lbChlorides.ForeColor != Color.Red)
            {
                gbElectrolytes.ForeColor = Color.Black;
            }
        }

        private void ClearFields()
        {
            tbAlbumen.Text = string.Empty;
            tbChlorides.Text = string.Empty;
            tbCreatinine.Text = string.Empty;
            tbFullName.Text = string.Empty;
            tbGlucose.Text = string.Empty;
            tbKetones.Text = string.Empty;
            tbNitrite.Text = string.Empty;
            tbPH.Text = string.Empty;
            tbPotassium.Text = string.Empty;
            tbSodium.Text = string.Empty;
            tbUrobilinogen.Text = string.Empty;
            cbGender.SelectedItem = null;
            dtpDOB.Value = dtpDOB.MinDate;
            cbPregnancy.Checked = false;
        }

        private void FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ' &&
                e.KeyChar != '‘' &&
                e.KeyChar != '`' &&
                e.KeyChar != '\'' &&
                e.KeyChar != '’' &&
                !char.IsControl(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }

        private void GeneratePDFReport()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $@"/Patient/PDF/{DateTime.Now:ddMMyyyy}/";
            string fileName = tbFullName.Text + $@" {DateTime.Now:ddMMyyyy}.pdf";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            string fileRoute = filePath + fileName;

            Document document = new();
            try
            {
                int age = CalculateAge(dtpDOB.Value);

                if (age <= 18)
                {
                    analysisOfUrineLimits = new()
                    {
                        pHMin = 5.0,
                        pHMax = 7.0,
                        glucose = 0,
                        albumenMin = 0,
                        albumenMax = 0.2,
                        ketones = 0,
                        nitrite = 0,
                        urobilinogenMin = 0.1,
                        urobilinogenMax = 1.0,
                        creatinineMin = 0.2,
                        creatinineMax = 0.5,
                        electrolytesSodiumMin = 133,
                        electrolytesSodiumMax = 146,
                        electrolytesPotassiumMin = 3.5,
                        electrolytesPotassiumMax = 5.5,
                        electrolytesChloridesMin = 98,
                        electrolytesChloridesMax = 108,
                    };
                }
                else if (cbGender.SelectedIndex == 0)
                {
                    if (cbPregnancy.Checked)
                    {
                        analysisOfUrineLimits = new()
                        {
                            pHMin = 5.0,
                            pHMax = 7.0,
                            glucose = 0,
                            albumenMin = 0,
                            albumenMax = 0.3,
                            ketones = 0,
                            nitrite = 0,
                            urobilinogenMin = 0.1,
                            urobilinogenMax = 1.0,
                            creatinineMin = 0.3,
                            creatinineMax = 1.0,
                            electrolytesSodiumMin = 133,
                            electrolytesSodiumMax = 145,
                            electrolytesPotassiumMin = 3.5,
                            electrolytesPotassiumMax = 5.1,
                            electrolytesChloridesMin = 98,
                            electrolytesChloridesMax = 107,
                        };
                    }
                    else
                    {
                        analysisOfUrineLimits = new()
                        {
                            pHMin = 5.0,
                            pHMax = 7.0,
                            glucose = 0,
                            albumenMin = 0,
                            albumenMax = 0.2,
                            ketones = 0,
                            nitrite = 0,
                            urobilinogenMin = 0.1,
                            urobilinogenMax = 1.0,
                            creatinineMin = 0.7,
                            creatinineMax = 1.2,
                            electrolytesSodiumMin = 133,
                            electrolytesSodiumMax = 145,
                            electrolytesPotassiumMin = 3.5,
                            electrolytesPotassiumMax = 5.1,
                            electrolytesChloridesMin = 98,
                            electrolytesChloridesMax = 107,
                        };
                    }
                }
                else if (cbGender.SelectedIndex == 1)
                {
                    analysisOfUrineLimits = new()
                    {
                        pHMin = 5.0,
                        pHMax = 7.0,
                        glucose = 0,
                        albumenMin = 0,
                        albumenMax = 0.2,
                        ketones = 0,
                        nitrite = 0,
                        urobilinogenMin = 0.1,
                        urobilinogenMax = 1.0,
                        creatinineMin = 0.8,
                        creatinineMax = 1.3,
                        electrolytesSodiumMin = 133,
                        electrolytesSodiumMax = 145,
                        electrolytesPotassiumMin = 3.5,
                        electrolytesPotassiumMax = 5.1,
                        electrolytesChloridesMin = 98,
                        electrolytesChloridesMax = 107,
                    };
                }

                string MedicalWishes = "\n";

                if (Convert.ToDouble(tbPH.Text) < analysisOfUrineLimits.pHMin || Convert.ToDouble(tbPH.Text) > analysisOfUrineLimits.pHMin)
                {
                    MedicalWishes += "Незвично низький або високий рівень pH може вказувати на порушення функції нирок або сечових шляхів. Рекомендується проконсультуватися з лікарем для подальшого обстеження та оцінки стану нирок.\n\n";
                }

                if (Convert.ToDouble(tbGlucose.Text) < analysisOfUrineLimits.glucose || Convert.ToDouble(tbGlucose.Text) > analysisOfUrineLimits.glucose)
                {
                    MedicalWishes += "Присутність глюкози в сечі може вказувати на порушення обробки або засвоєння цукру в організмі. Це може бути пов'язано з діабетом або іншими станами. Рекомендується звернутися до лікаря для діагностики та управління цукровим діабетом або іншими станами, що викликають глюкозурію.\n\n";
                }

                if (Convert.ToDouble(tbAlbumen.Text) < analysisOfUrineLimits.albumenMin || Convert.ToDouble(tbAlbumen.Text) > analysisOfUrineLimits.albumenMax)
                {
                    MedicalWishes += "Присутність білка в сечі (протеїнурія) може вказувати на проблеми з нирками або сечовими шляхами. Це може бути пов'язано із запаленням, інфекцією, пошкодженням нирок або іншими станами. Рекомендується звернутися до лікаря для подальшого обстеження та оцінки стану нирок.\n\n";
                }

                if (Convert.ToDouble(tbKetones.Text) < analysisOfUrineLimits.ketones || Convert.ToDouble(tbKetones.Text) > analysisOfUrineLimits.ketones)
                {
                    MedicalWishes += "Присутність кетонів у сечі може вказувати на порушення обміну речовин, таке як голодування, діабетичний кетоацидоз або інші стани. Рекомендується звернутися до лікаря для оцінки та управління цими станами.\n\n";
                }

                if (Convert.ToDouble(tbNitrite.Text) < analysisOfUrineLimits.nitrite || Convert.ToDouble(tbNitrite.Text) > analysisOfUrineLimits.nitrite)
                {
                    MedicalWishes += "Присутність нітратів у сечі може вказувати на наявність бактеріальної інфекції сечових шляхів. Рекомендується звернутися до лікаря для проведення додаткових обстежень та визначення причини інфекції.\n\n";
                }

                if (Convert.ToDouble(tbUrobilinogen.Text) < analysisOfUrineLimits.urobilinogenMin || Convert.ToDouble(tbUrobilinogen.Text) > analysisOfUrineLimits.urobilinogenMax)
                {
                    MedicalWishes += "Зміна рівня уробіліногену в сечі може бути пов'язана з проблемами печінки, жовчного міхура або жовчовивідних шляхів. Рекомендується звернутися до лікаря для подальшого обстеження та визначення причини зміни рівня уробіліногену.\n\n";
                }

                if (Convert.ToDouble(tbCreatinine.Text) < analysisOfUrineLimits.creatinineMin || Convert.ToDouble(tbUrobilinogen.Text) > analysisOfUrineLimits.creatinineMax)
                {
                    MedicalWishes += "Підвищений рівень креатиніну в сечі може вказувати на порушення функції нирок. Рекомендується звернутися до лікаря для подальшого обстеження та оцінки функції нирок.\n\n";
                }

                if (
                    (Convert.ToDouble(tbSodium.Text) < analysisOfUrineLimits.electrolytesSodiumMin || Convert.ToDouble(tbSodium.Text) > analysisOfUrineLimits.electrolytesSodiumMax) || 
                    (Convert.ToDouble(tbPotassium.Text) < analysisOfUrineLimits.electrolytesPotassiumMin || Convert.ToDouble(tbPotassium.Text) > analysisOfUrineLimits.electrolytesPotassiumMax) ||
                    (Convert.ToDouble(tbChlorides.Text) < analysisOfUrineLimits.electrolytesChloridesMin || Convert.ToDouble(tbChlorides.Text) > analysisOfUrineLimits.electrolytesChloridesMax)
                )
                {
                    MedicalWishes += "Зміни рівня електролітів у сечі можуть бути пов'язані з порушеннями балансу електролітів в організмі або функцією нирок. Рекомендується звернутися до лікаря для подальшої оцінки та управління цими станами.\n\n";
                }

                BaseFont baseFont = BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font font = new(baseFont, 12);

                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileRoute, FileMode.Create));

                document.Open();
                document.NewPage();

                Paragraph Label = new("Біохімічний аналіз сечі\n\n", font);
                Label.Alignment = Element.ALIGN_CENTER;
                Paragraph FullName = new(lbFullName.Text.ToString() + ": " + tbFullName.Text.ToString() + "\n", font);
                Paragraph DOB = new (lbDOB.Text.ToString() + ": " + dtpDOB.Text.ToString() + $@"({age})" + "\n", font);
                Paragraph AnalizeDate = new ("Дата: " + $@"{DateTime.Now:dd/MM/yyyy}" + "\n\n", font);

                document.Add(Label);
                document.Add(FullName);
                document.Add(DOB);
                document.Add(AnalizeDate);

                PdfPTable table = new(3);

                table.AddCell(new Phrase("Показник", font));
                table.AddCell(new Phrase("Результат", font));
                table.AddCell(new Phrase("Норма", font));

                Phrase pHMin = new(analysisOfUrineLimits.pHMin.ToString(), font);
                Phrase pHMax = new(analysisOfUrineLimits.pHMax.ToString(), font);
                Phrase phValues = new()
                {
                    pHMin,
                    "-",
                    pHMax
                };
                table.AddCell(new Phrase(lbPH.Text.ToString(), font));
                table.AddCell(new Phrase(tbPH.Text.ToString(), font));
                table.AddCell(phValues);

                table.AddCell(new Phrase(lbGlucose.Text.ToString(), font));
                table.AddCell(new Phrase(tbGlucose.Text.ToString(), font));
                table.AddCell(new Phrase(analysisOfUrineLimits.glucose.ToString(), font));

                Phrase albumenMin = new(analysisOfUrineLimits.albumenMin.ToString(), font);
                Phrase albumenMax = new(analysisOfUrineLimits.albumenMax.ToString(), font);
                Phrase albumenValues = new()
                {
                    albumenMin,
                    "-",
                    albumenMax
                };
                table.AddCell(new Phrase(lbAlbumen.Text.ToString(), font));
                table.AddCell(new Phrase(tbAlbumen.Text.ToString(), font));
                table.AddCell(albumenValues);

                table.AddCell(new Phrase(lbKetones.Text.ToString(), font));
                table.AddCell(new Phrase(tbKetones.Text.ToString(), font));
                table.AddCell(new Phrase(analysisOfUrineLimits.ketones.ToString(), font));

                table.AddCell(new Phrase(lbNitrite.Text.ToString(), font));
                table.AddCell(new Phrase(tbNitrite.Text.ToString(), font));
                table.AddCell(new Phrase(analysisOfUrineLimits.nitrite.ToString(), font));

                Phrase urobilinogenMin = new(analysisOfUrineLimits.urobilinogenMin.ToString(), font);
                Phrase urobilinogenMax = new(analysisOfUrineLimits.urobilinogenMax.ToString(), font);
                Phrase urobilinogenValues = new()
                {
                    urobilinogenMin,
                    "-",
                    urobilinogenMax
                };
                table.AddCell(new Phrase(lbUrobilinogen.Text.ToString(), font));
                table.AddCell(new Phrase(tbUrobilinogen.Text.ToString(), font));
                table.AddCell(urobilinogenValues);

                Phrase creatinineMin = new(analysisOfUrineLimits.creatinineMin.ToString(), font);
                Phrase creatinineMax = new(analysisOfUrineLimits.creatinineMax.ToString(), font);
                Phrase creatinineValues = new()
                {
                    creatinineMin,
                    "-",
                    creatinineMax
                };
                table.AddCell(new Phrase(lbCreatinine.Text.ToString(), font));
                table.AddCell(new Phrase(tbCreatinine.Text.ToString(), font));
                table.AddCell(creatinineValues);

                Phrase Electrolytes = new(gbElectrolytes.Text.ToString(), font);
                Phrase Sodium = new(lbSodium.Text.ToString().ToLower(), font);
                Phrase ElectrolytesSodium = new()
                {
                    Electrolytes,
                    " ",
                    Sodium
                };
                Phrase electrolytesSodiumMin = new(analysisOfUrineLimits.electrolytesSodiumMin.ToString(), font);
                Phrase electrolytesSodiumMax = new(analysisOfUrineLimits.electrolytesSodiumMax.ToString(), font);
                Phrase electrolytesSodiumValues = new()
                {
                    electrolytesSodiumMin,
                    "-",
                    electrolytesSodiumMax
                };
                table.AddCell(ElectrolytesSodium);
                table.AddCell(new Phrase(tbSodium.Text.ToString(), font));
                table.AddCell(electrolytesSodiumValues);

                Phrase electrolytesPotassiumMin = new(analysisOfUrineLimits.electrolytesPotassiumMin.ToString(), font);
                Phrase electrolytesPotassiumMax = new(analysisOfUrineLimits.electrolytesPotassiumMax.ToString(), font);
                Phrase electrolytesPotassiumValues = new()
                {
                    electrolytesPotassiumMin,
                    "-",
                    electrolytesPotassiumMax
                };
                Phrase Potassium = new(lbPotassium.Text.ToString().ToLower(), font);
                Phrase ElectrolytesPotassium = new()
                {
                    Electrolytes,
                    " ",
                    Potassium
                };
                table.AddCell(ElectrolytesPotassium);
                table.AddCell(new Phrase(tbSodium.Text.ToString(), font));
                table.AddCell(electrolytesPotassiumValues);

                Phrase electrolytesChloridesMin = new(analysisOfUrineLimits.electrolytesChloridesMin.ToString(), font);
                Phrase electrolytesChloridesMax = new(analysisOfUrineLimits.electrolytesChloridesMax.ToString(), font);
                Phrase electrolytesChloridesValues = new()
                {
                    electrolytesChloridesMin,
                    "-",
                    electrolytesChloridesMax
                };
                Phrase Chlorides = new(lbChlorides.Text.ToString().ToLower(), font);
                Phrase ElectrolytesChlorides = new()
                {
                    Electrolytes,
                    " ",
                    Potassium
                };
                table.AddCell(ElectrolytesChlorides);
                table.AddCell(new Phrase(tbSodium.Text.ToString(), font));
                table.AddCell(electrolytesChloridesValues);

                document.Add(table);

                Paragraph Wishes = new(MedicalWishes, font);

                document.Add(Wishes);
            }
            catch
            {
                MessageBox.Show("Помилка при створені файла. Зверніться до адміністратора!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                document.Close();
            }

            if (File.Exists(fileRoute))
            {
                Process.Start(fileRoute);
            }
            else
            {
                MessageBox.Show("Помилка при створені файла. Зверніться до адміністратора!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == true)
            {
                GeneratePDFReport();
            }
        }

        public int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan difference = currentDate - birthDate;
            int age = (int)(difference.Days / 365.25);
            return age;
        }
    }
}
