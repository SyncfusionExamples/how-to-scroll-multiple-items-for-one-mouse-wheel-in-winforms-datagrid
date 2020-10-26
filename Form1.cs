using SfDataGridDemo;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;

namespace SfDataGridDemo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes the new instance for the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            sfDataGrid1.DataSource = new OrderInfoCollection().OrdersListDetails;
            sfDataGrid1.TableControl.MouseWheel += OnTableControl_MouseWheel;
        }

        private void OnTableControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta == 0)
                return;

            var smallChange = sfDataGrid1.TableControl.ScrollRows.ScrollBar.SmallChange;
            if (e.Delta > 0)
                sfDataGrid1.TableControl.ScrollRows.ScrollBar.Value -= (4 * smallChange);
            else
                sfDataGrid1.TableControl.ScrollRows.ScrollBar.Value += (4 * smallChange);

            this.sfDataGrid1.TableControl.UpdateScrollBars();
            this.sfDataGrid1.TableControl.Invalidate();
        }

        #endregion
    }
}
