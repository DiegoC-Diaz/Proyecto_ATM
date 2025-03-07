using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ATM
{
    internal class PopUps
    {
        
        public PopUps()
        {
        }

        public void mostrar_error(String Error, Form Parent)
        {
            
            Form modalBackground = new Form();
            Form parentForm = Parent;
            using (modalForm modal = new modalForm(Error))
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = 0.5d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = parentForm.Size;
                modalBackground.Location = parentForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;
                modal.error = Error;
                //int parentX = parent.Location.X;
                //int parentY = parent.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();

            }

        }

        public void mostrar_billetes_dispensados(int billetes_100,int billetes_200,int billetes_500, Form Parent)
        {

  
            Form parentForm = Parent;
            using (ModalRetiro modal = new ModalRetiro(billetes_100,billetes_200,billetes_500))
            {
                modal.StartPosition = FormStartPosition.Manual;
                modal.FormBorderStyle = FormBorderStyle.None;

                modal.Size = parentForm.Size;
                modal.Location = parentForm.Location;

                

                //int parentX = parent.Location.X;
                //int parentY = parent.Location.Y;

                modal.ShowDialog();
 

            }

        }


    }

}
