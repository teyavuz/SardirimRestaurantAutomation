using Sardirim_BLL;
using Sardirim_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sardirim_UI.Formlar.Kayıt_Sistemi
{
    public partial class NewStaffForm : Form
    {
        public NewStaffForm()
        {
            InitializeComponent();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck.Checked == true)
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Staffs tablosuna girilen veriler girilecek cmbStaffType'da MutfakElemanı->StaffTypeID2 Garson->StaffTypeID3 Vale->StaffTypeID4

            try
            {
                Staff staff = new Staff();

                staff.StaffName = txtStaffName.Text;
                staff.StaffSurname = txtStaffSurname.Text;
                staff.StaffPhone = txtStaffPhoneMasked.Text;
                if (cmbBranch.SelectedIndex == 0)
                {
                    staff.StaffBranchID = 1;
                }
                else if (cmbBranch.SelectedIndex == 1)
                {
                    staff.StaffBranchID = 2;
                }
                else if (cmbBranch.SelectedIndex == 2)
                {
                    staff.StaffBranchID = 3;
                }
                if (cmbStaffType.SelectedIndex == 0)
                {
                    staff.StaffTypeID = 2;
                }
                else if (cmbStaffType.SelectedIndex == 1)
                {
                    staff.StaffTypeID = 3;
                }
                else if (cmbStaffType.SelectedIndex == 2)
                {
                    staff.StaffTypeID = 4;
                }
                if (cmbGender.SelectedIndex == 0)
                {
                    staff.StaffGender = "Kadın";
                }
                else if (cmbGender.SelectedIndex == 1)
                {
                    staff.StaffGender = "Erkek";
                }
                staff.CreatorID = 2;
                staff.CreatDate = DateTime.Now;

                StaffRepository staffRepository = new StaffRepository();
                staffRepository.Add(staff);
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Oluştu.");
            }
            catch
            {
                MessageBox.Show("Bir sorun oluştu lütfen bilgileri doğru giriniz");
            }


        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
