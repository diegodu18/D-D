using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ScreenGame.Localization
{
    // Servicio mínimo para cargar pares clave/valor desde un JSON simple (archivo plano)
    public class LanguageService
    {
        private readonly Dictionary<string, string> _dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        // pathOrDir: either a file path to a json, or a directory where lang.{code}.json files live
        public LanguageService(string pathOrDir, string code = "es")
        {
            string fileToLoad = null;
            try
            {
                if (File.Exists(pathOrDir))
                {
                    fileToLoad = pathOrDir;
                }
                else if (Directory.Exists(pathOrDir))
                {
                    var f1 = Path.Combine(pathOrDir, $"lang.{code}.json");
                    var f2 = Path.Combine(pathOrDir, "lang.json");
                    if (File.Exists(f1)) fileToLoad = f1;
                    else if (File.Exists(f2)) fileToLoad = f2;
                }
                else
                {
                    // also try parent directory (in case a path without file was given)
                    var dir = Path.GetDirectoryName(pathOrDir) ?? pathOrDir;
                    var f1 = Path.Combine(dir, $"lang.{code}.json");
                    if (File.Exists(f1)) fileToLoad = f1;
                }
            }
            catch
            {
                // ignore errors and fall back to defaults
            }

            if (!string.IsNullOrEmpty(fileToLoad) && File.Exists(fileToLoad))
            {
                try
                {
                    var txt = File.ReadAllText(fileToLoad);
                    // detectar "key" : "value" pares de forma sencilla
                    var rx = new Regex(@"""(?<k>[^""]+)""\s*:\s*""(?<v>[^""]*)""", RegexOptions.Compiled);
                    foreach (Match m in rx.Matches(txt))
                    {
                        var k = m.Groups["k"].Value;
                        var v = m.Groups["v"].Value;
                        if (!_dict.ContainsKey(k)) _dict.Add(k, v);
                    }
                }
                catch
                {
                    // ignorar errores y usar claves por defecto
                }
            }
        }

        public string Get(string key)
        {
            if (string.IsNullOrEmpty(key)) return string.Empty;
            if (_dict.TryGetValue(key, out var v)) return v;
            return key; // fallback a la propia clave
        }
    }
}
