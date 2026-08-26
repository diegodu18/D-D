using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace ScreenGame
{
    public partial class Menu : Form
    {
        private Localization.LanguageService _lang;
        private Guid _currentUserId = Guid.Empty;
        private string _currentLangCode = "es";
        public Menu()
        {
            InitializeComponent();
            // determinar idioma guardado
            var langCodeFile = Path.Combine(Application.StartupPath, "lang_code.txt");
            if (File.Exists(langCodeFile))
            {
                var c = File.ReadAllText(langCodeFile).Trim();
                if (!string.IsNullOrEmpty(c)) _currentLangCode = c;
            }
            _lang = new Localization.LanguageService(Application.StartupPath, _currentLangCode);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // cargar textos de idioma
            btnNewGame.Text = _lang.Get("NewGame");
            btnLoadGame.Text = _lang.Get("LoadGame");
            btnSettings.Text = _lang.Get("Settings");
            btnExitGame.Text = _lang.Get("Exit");

            // determinar usuario actual (archivo current_user.txt con GUID)
            var userFile = Path.Combine(Application.StartupPath, "current_user.txt");
            if (File.Exists(userFile))
            {
                var txt = File.ReadAllText(userFile).Trim();
                Guid g;
                if (Guid.TryParse(txt, out g)) _currentUserId = g;
            }

            // comprobar si hay personajes para el usuario en characters.json
            var charactersFile = Path.Combine(Application.StartupPath, "characters.json");
            var canLoad = false;
            if (File.Exists(charactersFile) && _currentUserId != Guid.Empty)
            {
                var content = File.ReadAllText(charactersFile);
                // búsqueda simple: comprobar si aparece el GUID en el json
                if (content.IndexOf(_currentUserId.ToString(), StringComparison.OrdinalIgnoreCase) >= 0)
                    canLoad = true;
            }
            btnLoadGame.Enabled = canLoad;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Acción simple: abrir nueva ventana o iniciar flujo de nueva partida
            MessageBox.Show(_lang.Get("NewGame") + " -> " + _lang.Get("NotImplemented"));
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            if (!btnLoadGame.Enabled)
            {
                MessageBox.Show(_lang.Get("LoadGame") + " -> " + _lang.Get("NoCharacters"));
                return;
            }
            MessageBox.Show(_lang.Get("LoadGame") + " -> " + _lang.Get("NotImplemented"));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Navegación: ocultar menú y mostrar Settings no modal
            var f = new Settings();
            f.StartPosition = FormStartPosition.CenterScreen;
            // cuando Settings se cierre, volver a mostrar este menú y recargar idioma
            f.FormClosed += (s, args) =>
            {
                try
                {
                    // leer idioma seleccionado en Settings (si cambió)
                    var codeFile = Path.Combine(Application.StartupPath, "lang_code.txt");
                    if (File.Exists(codeFile))
                    {
                        var c = File.ReadAllText(codeFile).Trim();
                        if (!string.IsNullOrEmpty(c)) _currentLangCode = c;
                    }
                    _lang = new Localization.LanguageService(Application.StartupPath, _currentLangCode);
                    btnNewGame.Text = _lang.Get("NewGame");
                    btnLoadGame.Text = _lang.Get("LoadGame");
                    btnSettings.Text = _lang.Get("Settings");
                    btnExitGame.Text = _lang.Get("Exit");
                    this.Text = _lang.Get("AppTitle");
                }
                catch { }
                this.Show();
            };
            this.Hide();
            f.Show(this);
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
