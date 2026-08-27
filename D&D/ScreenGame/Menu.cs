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
            ConfigureDungeonsAndDragonsTheme();
            // determinar idioma guardado
            var langCodeFile = Path.Combine(Application.StartupPath, "lang_code.txt");
            if (File.Exists(langCodeFile))
            {
                var c = File.ReadAllText(langCodeFile).Trim();
                if (!string.IsNullOrEmpty(c)) _currentLangCode = c;
            }
            _lang = new Localization.LanguageService(Application.StartupPath, _currentLangCode);
        }

        private void ConfigureDungeonsAndDragonsTheme()
        {
            BackColor = Color.FromArgb(25, 20, 18);
            ForeColor = Color.FromArgb(232, 208, 158);
            Font = new Font("Georgia", 10F, FontStyle.Regular);

            lblTitle.Font = new Font("Georgia", 25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(218, 166, 73);
            lblSubtitle.Font = new Font("Georgia", 9F, FontStyle.Bold);
            lblSubtitle.ForeColor = Color.FromArgb(178, 143, 91);
            lblDivider.ForeColor = Color.FromArgb(124, 87, 39);

            StyleMenuButton(btnNewGame);
            StyleMenuButton(btnLoadGame);
            StyleMenuButton(btnSettings);
            StyleMenuButton(btnExitGame);
            btnExitGame.ForeColor = Color.FromArgb(196, 125, 91);

            Paint += Menu_Paint;
        }

        private void StyleMenuButton(Button button)
        {
            button.BackColor = Color.FromArgb(54, 39, 31);
            button.ForeColor = Color.FromArgb(232, 208, 158);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.FromArgb(145, 105, 48);
            button.FlatAppearance.BorderSize = 1;
            button.Font = new Font("Georgia", 11F, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(87, 59, 33), 1F))
            {
                e.Graphics.DrawRectangle(pen, 18, 18, ClientSize.Width - 36, ClientSize.Height - 36);
                e.Graphics.DrawLine(pen, 45, 158, 270, 158);
                e.Graphics.DrawLine(pen, 580, 158, 805, 158);
            }

            using (var brush = new SolidBrush(Color.FromArgb(145, 105, 48)))
            {
                e.Graphics.DrawString("✦", new Font("Georgia", 18F), brush, 262, 132);
                e.Graphics.DrawString("✦", new Font("Georgia", 18F), brush, 565, 132);
            }
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
