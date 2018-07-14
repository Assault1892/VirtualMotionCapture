﻿namespace ControlWindow
{
    partial class ControlWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ImportVRMButton = new System.Windows.Forms.Button();
            this.CalibrationButton = new System.Windows.Forms.Button();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.LoadSettingsButton = new System.Windows.Forms.Button();
            this.WindowBorderCheckBox = new System.Windows.Forms.CheckBox();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorTransparentButton = new System.Windows.Forms.Button();
            this.ColorCustom1Button = new System.Windows.Forms.Button();
            this.ColorWhiteButton = new System.Windows.Forms.Button();
            this.ColorBlueButton = new System.Windows.Forms.Button();
            this.ColorGreenButton = new System.Windows.Forms.Button();
            this.CameraGridCheckBox = new System.Windows.Forms.CheckBox();
            this.FreeCameraButton = new System.Windows.Forms.Button();
            this.BackCameraButton = new System.Windows.Forms.Button();
            this.FrontCameraButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WindowClickThroughCheckBox = new System.Windows.Forms.CheckBox();
            this.LipSyncCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.LipSyncDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GainScrollBar = new System.Windows.Forms.HScrollBar();
            this.GainLabel = new System.Windows.Forms.Label();
            this.LipSyncDeviceRefreshButton = new System.Windows.Forms.Button();
            this.WeightThreasholdLabel = new System.Windows.Forms.Label();
            this.WeightThreasholdScrollBar = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxWeightCheckBox = new System.Windows.Forms.CheckBox();
            this.MaxWeightEmphasisCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportVRMButton
            // 
            this.ImportVRMButton.Location = new System.Drawing.Point(351, 13);
            this.ImportVRMButton.Margin = new System.Windows.Forms.Padding(4);
            this.ImportVRMButton.Name = "ImportVRMButton";
            this.ImportVRMButton.Size = new System.Drawing.Size(168, 62);
            this.ImportVRMButton.TabIndex = 2;
            this.ImportVRMButton.Text = "VRM読込";
            this.ImportVRMButton.UseVisualStyleBackColor = true;
            this.ImportVRMButton.Click += new System.EventHandler(this.ImportVRMButton_Click);
            // 
            // CalibrationButton
            // 
            this.CalibrationButton.Location = new System.Drawing.Point(351, 83);
            this.CalibrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalibrationButton.Name = "CalibrationButton";
            this.CalibrationButton.Size = new System.Drawing.Size(168, 62);
            this.CalibrationButton.TabIndex = 3;
            this.CalibrationButton.Text = "キャリブレーション";
            this.CalibrationButton.UseVisualStyleBackColor = true;
            this.CalibrationButton.Click += new System.EventHandler(this.CalibrationButton_Click);
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(12, 82);
            this.SaveSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(149, 62);
            this.SaveSettingsButton.TabIndex = 1;
            this.SaveSettingsButton.Text = "設定の保存";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // LoadSettingsButton
            // 
            this.LoadSettingsButton.Location = new System.Drawing.Point(12, 12);
            this.LoadSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadSettingsButton.Name = "LoadSettingsButton";
            this.LoadSettingsButton.Size = new System.Drawing.Size(149, 62);
            this.LoadSettingsButton.TabIndex = 0;
            this.LoadSettingsButton.Text = "設定の読込";
            this.LoadSettingsButton.UseVisualStyleBackColor = true;
            this.LoadSettingsButton.Click += new System.EventHandler(this.LoadSettingsButton_Click);
            // 
            // WindowBorderCheckBox
            // 
            this.WindowBorderCheckBox.AutoSize = true;
            this.WindowBorderCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.WindowBorderCheckBox.Location = new System.Drawing.Point(291, 81);
            this.WindowBorderCheckBox.Name = "WindowBorderCheckBox";
            this.WindowBorderCheckBox.Size = new System.Drawing.Size(224, 32);
            this.WindowBorderCheckBox.TabIndex = 10;
            this.WindowBorderCheckBox.Text = "ウインドウ枠の非表示";
            this.WindowBorderCheckBox.UseVisualStyleBackColor = false;
            this.WindowBorderCheckBox.CheckedChanged += new System.EventHandler(this.WindowBorderCheckBox_CheckedChanged);
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.TopMostCheckBox.Location = new System.Drawing.Point(12, 81);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(279, 32);
            this.TopMostCheckBox.TabIndex = 9;
            this.TopMostCheckBox.Text = "ウインドウを常に手前に表示";
            this.TopMostCheckBox.UseVisualStyleBackColor = false;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // ColorTransparentButton
            // 
            this.ColorTransparentButton.Location = new System.Drawing.Point(411, 12);
            this.ColorTransparentButton.Name = "ColorTransparentButton";
            this.ColorTransparentButton.Size = new System.Drawing.Size(104, 62);
            this.ColorTransparentButton.TabIndex = 8;
            this.ColorTransparentButton.Text = "透過";
            this.ColorTransparentButton.UseVisualStyleBackColor = true;
            this.ColorTransparentButton.Click += new System.EventHandler(this.ColorTransparentButton_Click);
            // 
            // ColorCustom1Button
            // 
            this.ColorCustom1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.ColorCustom1Button.Location = new System.Drawing.Point(300, 12);
            this.ColorCustom1Button.Margin = new System.Windows.Forms.Padding(4);
            this.ColorCustom1Button.Name = "ColorCustom1Button";
            this.ColorCustom1Button.Size = new System.Drawing.Size(104, 62);
            this.ColorCustom1Button.TabIndex = 7;
            this.ColorCustom1Button.Text = "カスタム";
            this.toolTip1.SetToolTip(this.ColorCustom1Button, "右クリックで色の変更");
            this.ColorCustom1Button.UseVisualStyleBackColor = false;
            this.ColorCustom1Button.Click += new System.EventHandler(this.ColorCustom1Button_Click);
            this.ColorCustom1Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorCustom1Button_MouseDown);
            // 
            // ColorWhiteButton
            // 
            this.ColorWhiteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ColorWhiteButton.Location = new System.Drawing.Point(204, 12);
            this.ColorWhiteButton.Margin = new System.Windows.Forms.Padding(4);
            this.ColorWhiteButton.Name = "ColorWhiteButton";
            this.ColorWhiteButton.Size = new System.Drawing.Size(88, 62);
            this.ColorWhiteButton.TabIndex = 6;
            this.ColorWhiteButton.Text = "白240";
            this.ColorWhiteButton.UseVisualStyleBackColor = false;
            this.ColorWhiteButton.Click += new System.EventHandler(this.ColorWhiteButton_Click);
            // 
            // ColorBlueButton
            // 
            this.ColorBlueButton.BackColor = System.Drawing.Color.Blue;
            this.ColorBlueButton.Location = new System.Drawing.Point(108, 12);
            this.ColorBlueButton.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBlueButton.Name = "ColorBlueButton";
            this.ColorBlueButton.Size = new System.Drawing.Size(88, 62);
            this.ColorBlueButton.TabIndex = 5;
            this.ColorBlueButton.Text = "BB";
            this.ColorBlueButton.UseVisualStyleBackColor = false;
            this.ColorBlueButton.Click += new System.EventHandler(this.ColorBlueButton_Click);
            // 
            // ColorGreenButton
            // 
            this.ColorGreenButton.BackColor = System.Drawing.Color.Lime;
            this.ColorGreenButton.Location = new System.Drawing.Point(12, 12);
            this.ColorGreenButton.Margin = new System.Windows.Forms.Padding(4);
            this.ColorGreenButton.Name = "ColorGreenButton";
            this.ColorGreenButton.Size = new System.Drawing.Size(88, 62);
            this.ColorGreenButton.TabIndex = 4;
            this.ColorGreenButton.Text = "GB";
            this.ColorGreenButton.UseVisualStyleBackColor = false;
            this.ColorGreenButton.Click += new System.EventHandler(this.ColorGreenButton_Click);
            // 
            // CameraGridCheckBox
            // 
            this.CameraGridCheckBox.AutoSize = true;
            this.CameraGridCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.CameraGridCheckBox.Location = new System.Drawing.Point(355, 108);
            this.CameraGridCheckBox.Name = "CameraGridCheckBox";
            this.CameraGridCheckBox.Size = new System.Drawing.Size(159, 32);
            this.CameraGridCheckBox.TabIndex = 14;
            this.CameraGridCheckBox.Text = "グリッドの表示";
            this.CameraGridCheckBox.UseVisualStyleBackColor = false;
            this.CameraGridCheckBox.CheckedChanged += new System.EventHandler(this.CameraGridCheckBox_CheckedChanged);
            // 
            // FreeCameraButton
            // 
            this.FreeCameraButton.Location = new System.Drawing.Point(352, 12);
            this.FreeCameraButton.Margin = new System.Windows.Forms.Padding(4);
            this.FreeCameraButton.Name = "FreeCameraButton";
            this.FreeCameraButton.Size = new System.Drawing.Size(162, 62);
            this.FreeCameraButton.TabIndex = 13;
            this.FreeCameraButton.Text = "フリー";
            this.toolTip1.SetToolTip(this.FreeCameraButton, "ホイール回転で拡大縮小・ホイールドラッグで上下左右移動・右クリックドラッグで回転");
            this.FreeCameraButton.UseVisualStyleBackColor = true;
            this.FreeCameraButton.Click += new System.EventHandler(this.FreeCameraButton_Click);
            // 
            // BackCameraButton
            // 
            this.BackCameraButton.Location = new System.Drawing.Point(182, 12);
            this.BackCameraButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackCameraButton.Name = "BackCameraButton";
            this.BackCameraButton.Size = new System.Drawing.Size(162, 62);
            this.BackCameraButton.TabIndex = 12;
            this.BackCameraButton.Text = "バック";
            this.toolTip1.SetToolTip(this.BackCameraButton, "ホイール回転で拡大縮小・ホイールドラッグで上下移動");
            this.BackCameraButton.UseVisualStyleBackColor = true;
            this.BackCameraButton.Click += new System.EventHandler(this.BackCameraButton_Click);
            // 
            // FrontCameraButton
            // 
            this.FrontCameraButton.Location = new System.Drawing.Point(12, 12);
            this.FrontCameraButton.Margin = new System.Windows.Forms.Padding(4);
            this.FrontCameraButton.Name = "FrontCameraButton";
            this.FrontCameraButton.Size = new System.Drawing.Size(162, 62);
            this.FrontCameraButton.TabIndex = 11;
            this.FrontCameraButton.Text = "フロント";
            this.toolTip1.SetToolTip(this.FrontCameraButton, "ホイール回転で拡大縮小・ホイールドラッグで上下移動");
            this.FrontCameraButton.UseVisualStyleBackColor = true;
            this.FrontCameraButton.Click += new System.EventHandler(this.FrontCameraButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "カメラは画面をクリックしてアクティブにしてから操作できます";
            // 
            // WindowClickThroughCheckBox
            // 
            this.WindowClickThroughCheckBox.AutoSize = true;
            this.WindowClickThroughCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.WindowClickThroughCheckBox.Location = new System.Drawing.Point(12, 115);
            this.WindowClickThroughCheckBox.Name = "WindowClickThroughCheckBox";
            this.WindowClickThroughCheckBox.Size = new System.Drawing.Size(193, 32);
            this.WindowClickThroughCheckBox.TabIndex = 11;
            this.WindowClickThroughCheckBox.Text = "マウス操作を透過";
            this.WindowClickThroughCheckBox.UseVisualStyleBackColor = false;
            this.WindowClickThroughCheckBox.CheckedChanged += new System.EventHandler(this.WindowClickThroughCheckBox_CheckedChanged);
            // 
            // LipSyncCheckBox
            // 
            this.LipSyncCheckBox.AutoSize = true;
            this.LipSyncCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.LipSyncCheckBox.Location = new System.Drawing.Point(13, 7);
            this.LipSyncCheckBox.Name = "LipSyncCheckBox";
            this.LipSyncCheckBox.Size = new System.Drawing.Size(130, 32);
            this.LipSyncCheckBox.TabIndex = 4;
            this.LipSyncCheckBox.Text = "リップシンク";
            this.toolTip1.SetToolTip(this.LipSyncCheckBox, "リップシンク機能を有効にします");
            this.LipSyncCheckBox.UseVisualStyleBackColor = false;
            this.LipSyncCheckBox.CheckedChanged += new System.EventHandler(this.LipSyncCheckBox_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 193);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CalibrationButton);
            this.tabPage1.Controls.Add(this.ImportVRMButton);
            this.tabPage1.Controls.Add(this.SaveSettingsButton);
            this.tabPage1.Controls.Add(this.LoadSettingsButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "設定 　";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WindowClickThroughCheckBox);
            this.tabPage2.Controls.Add(this.ColorGreenButton);
            this.tabPage2.Controls.Add(this.WindowBorderCheckBox);
            this.tabPage2.Controls.Add(this.ColorBlueButton);
            this.tabPage2.Controls.Add(this.TopMostCheckBox);
            this.tabPage2.Controls.Add(this.ColorWhiteButton);
            this.tabPage2.Controls.Add(this.ColorTransparentButton);
            this.tabPage2.Controls.Add(this.ColorCustom1Button);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "背景色 　";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CameraGridCheckBox);
            this.tabPage3.Controls.Add(this.FrontCameraButton);
            this.tabPage3.Controls.Add(this.FreeCameraButton);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.BackCameraButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(526, 152);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "カメラ 　";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.MaxWeightEmphasisCheckBox);
            this.tabPage4.Controls.Add(this.MaxWeightCheckBox);
            this.tabPage4.Controls.Add(this.WeightThreasholdScrollBar);
            this.tabPage4.Controls.Add(this.GainScrollBar);
            this.tabPage4.Controls.Add(this.LipSyncDeviceRefreshButton);
            this.tabPage4.Controls.Add(this.LipSyncDeviceComboBox);
            this.tabPage4.Controls.Add(this.WeightThreasholdLabel);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.GainLabel);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.LipSyncCheckBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(526, 152);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "リップシンク 　";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "使用するデバイス";
            // 
            // LipSyncDeviceComboBox
            // 
            this.LipSyncDeviceComboBox.FormattingEnabled = true;
            this.LipSyncDeviceComboBox.Location = new System.Drawing.Point(176, 45);
            this.LipSyncDeviceComboBox.Name = "LipSyncDeviceComboBox";
            this.LipSyncDeviceComboBox.Size = new System.Drawing.Size(264, 36);
            this.LipSyncDeviceComboBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.LipSyncDeviceComboBox, "リップシンクに使用する音声入力デバイスを選択してください");
            this.LipSyncDeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.LipSyncDeviceComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "ゲイン(感度)";
            // 
            // GainScrollBar
            // 
            this.GainScrollBar.Location = new System.Drawing.Point(176, 84);
            this.GainScrollBar.Maximum = 2560;
            this.GainScrollBar.Minimum = 10;
            this.GainScrollBar.Name = "GainScrollBar";
            this.GainScrollBar.Size = new System.Drawing.Size(264, 26);
            this.GainScrollBar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.GainScrollBar, "入力の感度設定です。反応が悪い場合にあげてください");
            this.GainScrollBar.Value = 10;
            this.GainScrollBar.ValueChanged += new System.EventHandler(this.GainScrollBar_ValueChanged);
            // 
            // GainLabel
            // 
            this.GainLabel.Location = new System.Drawing.Point(441, 82);
            this.GainLabel.Name = "GainLabel";
            this.GainLabel.Size = new System.Drawing.Size(82, 30);
            this.GainLabel.TabIndex = 9;
            this.GainLabel.Text = "1.0";
            this.GainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LipSyncDeviceRefreshButton
            // 
            this.LipSyncDeviceRefreshButton.Location = new System.Drawing.Point(446, 45);
            this.LipSyncDeviceRefreshButton.Name = "LipSyncDeviceRefreshButton";
            this.LipSyncDeviceRefreshButton.Size = new System.Drawing.Size(70, 36);
            this.LipSyncDeviceRefreshButton.TabIndex = 10;
            this.LipSyncDeviceRefreshButton.Text = "更新";
            this.LipSyncDeviceRefreshButton.UseVisualStyleBackColor = true;
            this.LipSyncDeviceRefreshButton.Click += new System.EventHandler(this.LipSyncDeviceRefreshButton_Click);
            // 
            // WeightThreasholdLabel
            // 
            this.WeightThreasholdLabel.Location = new System.Drawing.Point(436, 112);
            this.WeightThreasholdLabel.Name = "WeightThreasholdLabel";
            this.WeightThreasholdLabel.Size = new System.Drawing.Size(87, 40);
            this.WeightThreasholdLabel.TabIndex = 13;
            this.WeightThreasholdLabel.Text = "0.000";
            this.WeightThreasholdLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WeightThreasholdScrollBar
            // 
            this.WeightThreasholdScrollBar.Location = new System.Drawing.Point(176, 114);
            this.WeightThreasholdScrollBar.Name = "WeightThreasholdScrollBar";
            this.WeightThreasholdScrollBar.Size = new System.Drawing.Size(264, 26);
            this.WeightThreasholdScrollBar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.WeightThreasholdScrollBar, "音素の最小レベルを設定します。ノイズで口が開いてしまうのを防ぎます");
            this.WeightThreasholdScrollBar.ValueChanged += new System.EventHandler(this.WeightThreasholdScrollBar_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "音素の最小";
            // 
            // MaxWeightCheckBox
            // 
            this.MaxWeightCheckBox.AutoSize = true;
            this.MaxWeightCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.MaxWeightCheckBox.Location = new System.Drawing.Point(149, 7);
            this.MaxWeightCheckBox.Name = "MaxWeightCheckBox";
            this.MaxWeightCheckBox.Size = new System.Drawing.Size(182, 32);
            this.MaxWeightCheckBox.TabIndex = 14;
            this.MaxWeightCheckBox.Text = "最大の音素のみ";
            this.toolTip1.SetToolTip(this.MaxWeightCheckBox, "最大の音素(あいうえお)のみ使用します");
            this.MaxWeightCheckBox.UseVisualStyleBackColor = false;
            this.MaxWeightCheckBox.CheckedChanged += new System.EventHandler(this.MaxWeightCheckBox_CheckedChanged);
            // 
            // MaxWeightEmphasisCheckBox
            // 
            this.MaxWeightEmphasisCheckBox.AutoSize = true;
            this.MaxWeightEmphasisCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.MaxWeightEmphasisCheckBox.Location = new System.Drawing.Point(334, 7);
            this.MaxWeightEmphasisCheckBox.Name = "MaxWeightEmphasisCheckBox";
            this.MaxWeightEmphasisCheckBox.Size = new System.Drawing.Size(188, 32);
            this.MaxWeightEmphasisCheckBox.TabIndex = 15;
            this.MaxWeightEmphasisCheckBox.Text = "最大音素の強調";
            this.toolTip1.SetToolTip(this.MaxWeightEmphasisCheckBox, "最大の音素(あいうえお)を強調して、はっきりと動くようにします。");
            this.MaxWeightEmphasisCheckBox.UseVisualStyleBackColor = false;
            this.MaxWeightEmphasisCheckBox.CheckedChanged += new System.EventHandler(this.MaxWeightEmphasisCheckBox_CheckedChanged);
            // 
            // ControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(552, 213);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ControlWindow";
            this.Text = "コントロールパネル";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImportVRMButton;
        private System.Windows.Forms.Button CalibrationButton;
        private System.Windows.Forms.Button ColorCustom1Button;
        private System.Windows.Forms.Button ColorWhiteButton;
        private System.Windows.Forms.Button ColorBlueButton;
        private System.Windows.Forms.Button ColorGreenButton;
        private System.Windows.Forms.Button ColorTransparentButton;
        private System.Windows.Forms.CheckBox WindowBorderCheckBox;
        private System.Windows.Forms.CheckBox TopMostCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FreeCameraButton;
        private System.Windows.Forms.Button BackCameraButton;
        private System.Windows.Forms.Button FrontCameraButton;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Button LoadSettingsButton;
        private System.Windows.Forms.CheckBox CameraGridCheckBox;
        private System.Windows.Forms.CheckBox WindowClickThroughCheckBox;
        private System.Windows.Forms.CheckBox LipSyncCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox LipSyncDeviceComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar GainScrollBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GainLabel;
        private System.Windows.Forms.Button LipSyncDeviceRefreshButton;
        private System.Windows.Forms.CheckBox MaxWeightCheckBox;
        private System.Windows.Forms.HScrollBar WeightThreasholdScrollBar;
        private System.Windows.Forms.Label WeightThreasholdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox MaxWeightEmphasisCheckBox;
    }
}