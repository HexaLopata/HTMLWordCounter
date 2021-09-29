using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VolgaIT.Views
{
    internal class FormsManager
    {
        public static FormsManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormsManager();
                return _instance;
            }
        }

        private static FormsManager _instance;
        private ApplicationContext _context;
        private readonly List<Form> _forms = new List<Form>();

        public void Show(Form form)
        {
            if (_forms.Count == 0)
            {
                _context = new ApplicationContext(form);
                _forms.Add(form);
                Application.Run(_context);
            }
            else
            {
                form.Show();
                if (!_forms.Contains(form))
                    _forms.Add(form);
                _context.MainForm = form;
            }
        }

        public void Close(Form form)
        {
            if (!_forms.Contains(form))
                throw new ArgumentException("Произведены действия с неизвестной формой");

            _forms.Remove(form);
            form.Close();
            if (_forms.Count > 0)
                _context.MainForm = _forms.Last();
            else
                Application.Exit();
        }
    }
}
