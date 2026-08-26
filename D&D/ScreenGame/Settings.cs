using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ScreenGame
{
    public partial class Settings : Form
    {
        private Form _parent;

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(Form parent) : this()
        {
            _parent = parent;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // cargar opciones de idioma
            cboLang.Items.Clear();
            cboLang.Items.Add(new KeyValuePair<string, string>("es", "Español"));
            cboLang.Items.Add(new KeyValuePair<string, string>("en", "English"));

            var langCodeFile = Path.Combine(Application.StartupPath, "lang_code.txt");
            string current = "es";
            if (File.Exists(langCodeFile)) current = File.ReadAllText(langCodeFile).Trim();
            for (int i = 0; i < cboLang.Items.Count; i++)
            {
                var kv = (KeyValuePair<string, string>)cboLang.Items[i];
                if (kv.Key == current) { cboLang.SelectedIndex = i; break; }
            }

            // Aplicar textos según idioma actual
            try
            {
                var lang = new Localization.LanguageService(Application.StartupPath, current);
                lblTitle.Text = lang.Get("Settings");
                btnClose.Text = lang.Get("Back");
                btnOK.Text = lang.Get("OK");
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // navegación: volver al formulario padre en lugar de simplemente cerrar el popup
            try
            {
                if (_parent != null)
                {
                    _parent.Show();
                }
                else if (this.Owner != null)
                {
                    this.Owner.Show();
                }
            }
            catch { }
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var kv = (KeyValuePair<string, string>)cboLang.SelectedItem;
            try { File.WriteAllText(Path.Combine(Application.StartupPath, "lang_code.txt"), kv.Key); } catch { }
            var lang = new Localization.LanguageService(Application.StartupPath, kv.Key);
            lblTitle.Text = lang.Get("Settings");
            btnClose.Text = lang.Get("Back");
            btnOK.Text = lang.Get("OK");
            this.Close();
        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLang.SelectedItem == null) return;
            var kv = (KeyValuePair<string, string>)cboLang.SelectedItem;
            try { File.WriteAllText(Path.Combine(Application.StartupPath, "lang_code.txt"), kv.Key); } catch { }
            // recargar textos del propio Settings inmediatamente
            try
            {
                var lang = new Localization.LanguageService(Application.StartupPath, kv.Key);
                lblTitle.Text = lang.Get("Settings");
                btnClose.Text = lang.Get("Back");
                btnOK.Text = lang.Get("OK");
            }
            catch { }
        }
    }
}
