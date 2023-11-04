using System.Windows.Forms.DataVisualization.Charting;

namespace OutlookDemo.UserControls
{
    partial class Tab_Sort
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.RadioButton radioButtonOddEven;
        private System.Windows.Forms.RadioButton radioButtonRadix;
        private System.Windows.Forms.RadioButton radioButtonFibonacci;
        private System.Windows.Forms.Button buttonSort;
        private Chart chartResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultFunction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxRandom;
    }
}
