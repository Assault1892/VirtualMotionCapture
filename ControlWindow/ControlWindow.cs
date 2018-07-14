﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWindow
{
    public partial class ControlWindow : Form
    {
        public ControlWindow()
        {
            InitializeComponent();
        }

        public void ShowWindow()
        {
            this.Show();
            WindowLoader.Instance.LoadCustomBackgroundColor = LoadCustomBackgroundColor;
            WindowLoader.Instance.LoadHideBorder = LoadHideBorder;
            WindowLoader.Instance.LoadIsTopMost = LoadIsTopMost;
            WindowLoader.Instance.LoadShowCameraGrid = LoadShowCameraGrid;
            WindowLoader.Instance.LoadSetWindowClickThrough = LoadSetWindowClickThrough;
            WindowLoader.Instance.LoadLipSyncEnable = LoadLipSyncEnable;
            WindowLoader.Instance.LoadLipSyncDevice = LoadLipSyncDevice;
            WindowLoader.Instance.LoadLipSyncGain = LoadLipSyncGain;
            WindowLoader.Instance.LoadLipSyncDevice = LoadLipSyncDevice;
            WindowLoader.Instance.LoadLipSyncGain = LoadLipSyncGain;
            WindowLoader.Instance.LoadLipSyncMaxWeightEnable = LoadLipSyncMaxWeightEnable;
            WindowLoader.Instance.LoadLipSyncWeightThreashold = LoadLipSyncWeightThreashold;
            WindowLoader.Instance.LoadLipSyncMaxWeightEmphasis = LoadLipSyncMaxWeightEmphasis;
            GetLipSyncDevices();
        }

        private void ImportVRMButton_Click(object sender, EventArgs e)
        {
            var win = new VRMImportWindow();
            win.Show();
        }

        private void CalibrationButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WindowLoader.Instance.CurrentVRMFilePath))
            {
                MessageBoxWindow.Show("VRMモデルが読み込まれていません。先に読み込んでください。", "エラー");
                //return;
            }
            var win = new CalibrationWindow();
            win.Show();
        }

        private void ColorGreenButton_Click(object sender, EventArgs e)
        {
            WindowLoader.Instance.ChangeBackgroundColor?.Invoke(0.0f, 1.0f, 0.0f, false);
        }

        private void ColorBlueButton_Click(object sender, EventArgs e)
        {

            WindowLoader.Instance.ChangeBackgroundColor?.Invoke(0.0f, 0.0f, 1.0f, false);
        }

        private void ColorWhiteButton_Click(object sender, EventArgs e)
        {
            WindowLoader.Instance.ChangeBackgroundColor?.Invoke(0.9375f, 0.9375f, 0.9375f, false);
        }

        private Color customColor1 = Color.FromArgb(174, 212, 255);

        private void ColorCustom1Button_Click(object sender, EventArgs e)
        {
            WindowLoader.Instance.ChangeBackgroundColor?.Invoke(customColor1.R / 255f, customColor1.G / 255f, customColor1.B / 255f, true);
        }

        private void ColorCustom1Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var dialog = new ColorDialog();
                dialog.AllowFullOpen = true;
                dialog.AnyColor = true;
                dialog.Color = customColor1;
                dialog.FullOpen = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    customColor1 = dialog.Color;
                    ColorCustom1Button.BackColor = customColor1;
                }
            }
        }

        private void LoadCustomBackgroundColor(float r, float g, float b)
        {
            customColor1 = Color.FromArgb((int)(r * 255f), (int)(g * 255f), (int)(b * 255f));
            ColorCustom1Button.BackColor = customColor1;
        }

        private void ColorTransparentButton_Click(object sender, EventArgs e)
        {
            if (WindowBorderCheckBox.Checked == false) WindowBorderCheckBox.Checked = true;
            WindowLoader.Instance.SetBackgroundTransparent();
        }

        private void WindowBorderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WindowLoader.Instance.SetWindowBorder?.Invoke(WindowBorderCheckBox.Checked);
        }

        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WindowLoader.Instance.SetWindowTopMost?.Invoke(TopMostCheckBox.Checked);
        }

        private void LoadHideBorder(bool enable) {
            WindowBorderCheckBox.CheckedChanged -= WindowBorderCheckBox_CheckedChanged;
            WindowBorderCheckBox.Checked = enable;
            WindowBorderCheckBox.CheckedChanged += WindowBorderCheckBox_CheckedChanged;
        }

        private void LoadIsTopMost(bool enable) {
            TopMostCheckBox.CheckedChanged -= TopMostCheckBox_CheckedChanged;
            TopMostCheckBox.Checked = enable;
            TopMostCheckBox.CheckedChanged += TopMostCheckBox_CheckedChanged;
        }

        private void FrontCameraButton_Click(object sender, EventArgs e)
        {
            WindowLoader.Instance.ChangeCamera?.Invoke(CameraTypes.Front);
        }

        private void BackCameraButton_Click(object sender, EventArgs e)
        {
            WindowLoader.Instance.ChangeCamera?.Invoke(CameraTypes.Back);
        }

        private void FreeCameraButton_Click(object sender, EventArgs e)
        {
            WindowLoader.Instance.ChangeCamera?.Invoke(CameraTypes.Free);
        }

        private void LoadSettingsButton_Click(object sender, EventArgs e)
        {
            WindowLoader.Instance.LoadSettings?.Invoke();
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            WindowLoader.Instance.SaveSettings?.Invoke();
        }

        private void CameraGridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WindowLoader.Instance.SetGridVisible?.Invoke(CameraGridCheckBox.Checked);
        }

        void LoadShowCameraGrid(bool enable)
        {
            CameraGridCheckBox.CheckedChanged -= CameraGridCheckBox_CheckedChanged;
            CameraGridCheckBox.Checked = enable;
            CameraGridCheckBox.CheckedChanged += CameraGridCheckBox_CheckedChanged;
        }

        private void WindowClickThroughCheckBox_CheckedChanged(object sender, EventArgs e)
        {            
            WindowLoader.Instance.SetWindowClickThrough?.Invoke(WindowClickThroughCheckBox.Checked);
            if (TopMostCheckBox.Checked == false) TopMostCheckBox.Checked = true;
        }

        void LoadSetWindowClickThrough(bool enable)
        {
            WindowClickThroughCheckBox.CheckedChanged -= WindowClickThroughCheckBox_CheckedChanged;
            WindowClickThroughCheckBox.Checked = enable;
            WindowClickThroughCheckBox.CheckedChanged += WindowClickThroughCheckBox_CheckedChanged;
        }

        private void GetLipSyncDevices()
        {
            LipSyncDeviceComboBox.SelectedIndexChanged -= LipSyncDeviceComboBox_SelectedIndexChanged;
            var devices = WindowLoader.Instance.GetLipSyncDevices?.Invoke();
            var selectedItem = LipSyncDeviceComboBox.SelectedItem;
            LipSyncDeviceComboBox.Items.Clear();
            LipSyncDeviceComboBox.Items.AddRange(devices);
            if (selectedItem != null) LoadLipSyncDevice(selectedItem.ToString());
            LipSyncDeviceComboBox.SelectedIndexChanged += LipSyncDeviceComboBox_SelectedIndexChanged;
        }

        private void LipSyncCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WindowLoader.Instance.SetLipSyncEnable?.Invoke(LipSyncCheckBox.Checked);
        }

        void LoadLipSyncEnable(bool enable)
        {
            LipSyncCheckBox.CheckedChanged -= LipSyncCheckBox_CheckedChanged;
            LipSyncCheckBox.Checked = enable;
            LipSyncCheckBox.CheckedChanged += LipSyncCheckBox_CheckedChanged;
        }

        private void LipSyncDeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LipSyncDeviceComboBox.SelectedItem == null) return;
            if (LipSyncDeviceComboBox.SelectedItem.ToString().StartsWith("エラー:")) return;
            WindowLoader.Instance.SetLipSyncDevice?.Invoke(LipSyncDeviceComboBox.SelectedItem.ToString());
        }

        void LoadLipSyncDevice(string device)
        {
            if (string.IsNullOrEmpty(device)) return;
            if (LipSyncDeviceComboBox.Items.Contains(device))
            {
                LipSyncDeviceComboBox.SelectedItem = device;
            }
            else
            {
                LipSyncDeviceComboBox.Items.Insert(0, device.StartsWith("エラー:") ? device : "エラー:" + device);
            }
        }

        private void GainScrollBar_ValueChanged(object sender, EventArgs e)
        {
            float gain = GainScrollBar.Value / 10.0f;
            GainLabel.Text = gain.ToString("##.0");
            WindowLoader.Instance.SetLipSyncGain?.Invoke(gain);
        }

        void LoadLipSyncGain(float gain)
        {
            int value = (int)(gain * 10.0f);
            if (value < 10) value = 10;
            if (value > 2560) value = 2560;
            GainScrollBar.Value = value;
        }

        private void LipSyncDeviceRefreshButton_Click(object sender, EventArgs e)
        {
            GetLipSyncDevices();
        }

        private void MaxWeightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WindowLoader.Instance.SetLipSyncMaxWeightEnable?.Invoke(MaxWeightCheckBox.Checked);
        }

        void LoadLipSyncMaxWeightEnable(bool enable)
        {
            MaxWeightCheckBox.CheckedChanged -= MaxWeightCheckBox_CheckedChanged;
            MaxWeightCheckBox.Checked = enable;
            MaxWeightCheckBox.CheckedChanged += MaxWeightCheckBox_CheckedChanged;
        }

        private void WeightThreasholdScrollBar_ValueChanged(object sender, EventArgs e)
        {
            float threashold = WeightThreasholdScrollBar.Value / 1000.0f;
            WeightThreasholdLabel.Text = threashold.ToString("#.000");
            WindowLoader.Instance.SetLipSyncWeightThreashold?.Invoke(threashold);
        }

        void LoadLipSyncWeightThreashold(float gain)
        {
            int value = (int)(gain * 1000.0f);
            if (value < 0) value = 0;
            if (value > 1000) value = 1000;
            WeightThreasholdScrollBar.Value = value;
        }

        private void MaxWeightEmphasisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            WindowLoader.Instance.SetLipSyncMaxWeightEmphasis?.Invoke(MaxWeightEmphasisCheckBox.Checked);
        }

        void LoadLipSyncMaxWeightEmphasis(bool enable)
        {
            MaxWeightEmphasisCheckBox.CheckedChanged -= MaxWeightEmphasisCheckBox_CheckedChanged;
            MaxWeightEmphasisCheckBox.Checked = enable;
            MaxWeightEmphasisCheckBox.CheckedChanged += MaxWeightEmphasisCheckBox_CheckedChanged;
        }
    }
}
