﻿
Imports System.Windows.Forms

Public Class Calculator
    Dim SisaBulan As Integer
    Dim TotalSementara As Integer
    Dim TotalSementaraPlusSBLM As Integer
    Dim PeriksaLayer As Integer
    Dim PTKP As Integer
    Dim PKP As Integer
    Dim AsuransiSetahun As Integer
    Dim BiayaJabatan As Integer
    'Dim JHTSementara As Integer
    'Dim PKPSementara As Integer
    'Dim layer As Integer
    Dim PercentBasic As Double
    Dim PercentInsurance As Double
    Dim PercentJKK As Double
    Dim PercentIncome1 As Double
    Dim PercentIncome2 As Double
    Dim PercentIncome3 As Double
    Dim PercentIncome4 As Double
    Dim PercentIncome5 As Double
    Dim PercentIncome6 As Double
    Dim PercentIncome7 As Double
    Dim BasicSetahun As Integer
    'Dim InsuranceSetahun As Integer
    'Dim JKKSetahun As Integer
    'Dim Income1Setahun As Integer
    'Dim Income2Setahun As Integer
    'Dim Income3Setahun As Integer
    'Dim Income4Setahun As Integer
    'Dim Income5Setahun As Integer
    'Dim Income6Setahun As Integer
    'Dim Income7Setahun As Integer
    Dim TaxKomponen As Integer
    Dim TaxPembanding As Integer
    Dim PengaliJkJkk As Integer
    Dim NettBasic As Integer
    Dim NettInsurance As Integer
    Dim NettJKK As Integer
    Dim NettIncome1 As Integer
    Dim NettIncome2 As Integer
    Dim NettIncome3 As Integer
    Dim NettIncome4 As Integer
    Dim NettIncome5 As Integer
    Dim NettIncome6 As Integer
    Dim NettIncome7 As Integer
    Dim BasicAkhir As Integer
    Dim InsuranceAkhir As Integer
    Dim JKKAkhir As Integer
    Dim JKJKKBulanan As Integer
    Dim Income1Akhir As Integer
    Dim Income2Akhir As Integer
    Dim Income3Akhir As Integer
    Dim Income4Akhir As Integer
    Dim Income5Akhir As Integer
    Dim Income6Akhir As Integer
    Dim Income7Akhir As Integer
    Dim TotalNett As Integer


    Sub kosongkan()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox8.Text = ""
        ComboBox7.Text = ""
        txtPTKP.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox57.Clear()
        txtTHP.Clear()
        txtNettIncome7Akhir.Clear()
        txtNettIncome6Akhir.Clear()
        txtNettIncome5Akhir.Clear()
        txtNettIncome4Akhir.Clear()
        txtNettIncome3Akhir.Clear()
        txtNettIncome2Akhir.Clear()
        txtNettIncome1Akhir.Clear()
        txtNettJKKAkhir.Clear()
        txtNettInsuranceAkhir.Clear()
        txtNettBasicAkhir.Clear()
        TextBox21.Clear()
        TextBox22.Clear()
        TextBox23.Clear()
        TextBox24.Clear()
        TextBox25.Clear()
        TextBox26.Clear()
        TextBox27.Clear()
        TextBox28.Clear()
        TextBox29.Clear()
        TextBox30.Clear()
        TextBox31.Clear()
        TextBox32.Clear()
        TextBox33.Clear()
        TextBox34.Clear()
        TextBox35.Clear()
        TextBox36.Clear()
        TextBox37.Clear()
        TextBox38.Clear()
        TextBox39.Clear()
        TextBox40.Clear()
        TextBox41.Clear()
        TextBox42.Clear()
        TextBox43.Clear()
        TextBox44.Clear()
        TextBox45.Clear()
        TextBox46.Clear()
        TextBox47.Clear()
        TextBox48.Clear()
        TextBox49.Clear()
        TextBox50.Clear()
        TextBox51.Clear()
        TextBox52.Clear()
        TextBox53.Clear()
        TextBox54.Clear()
        TextBox55.Clear()
        CheckBox1.CheckState = CheckState.Unchecked
        CheckBox2.CheckState = CheckState.Unchecked
        CheckBox3.CheckState = CheckState.Unchecked
        CheckBox4.CheckState = CheckState.Unchecked
        CheckBox5.CheckState = CheckState.Unchecked
        CheckBox6.CheckState = CheckState.Unchecked
        CheckBox7.CheckState = CheckState.Unchecked
        CheckBox8.CheckState = CheckState.Unchecked
        CheckBox9.CheckState = CheckState.Unchecked
        CheckBox10.CheckState = CheckState.Unchecked
        CheckBox11.CheckState = CheckState.Unchecked
        CheckBox12.CheckState = CheckState.Unchecked
        CheckBox13.CheckState = CheckState.Unchecked
        CheckBox14.CheckState = CheckState.Unchecked
        CheckBox15.CheckState = CheckState.Unchecked
        CheckBox16.CheckState = CheckState.Unchecked
        CheckBox17.CheckState = CheckState.Unchecked
        CheckBox18.CheckState = CheckState.Unchecked
        CheckBox19.CheckState = CheckState.Unchecked
        CheckBox20.CheckState = CheckState.Unchecked
    End Sub

    Private Sub Calculator_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If Panel3.Text = "ADMIN CLIENT SERVICE" Then
        '    frmMenuAdminMPS.Enabled = True
        '    frmMenuAdminMPS.Show()
        'Else
        '    If Panel3.Text = "CLIENT SERVICE MGR" Then
        '        frmMenuManager.Enabled = True
        '        frmMenuManager.Show()
        '    Else
        '        If Panel3.Text = "DIRECTOR" Then
        '            frmMenuManager.Enabled = True
        '            frmMenuManager.Show()
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        GroupBox6.Enabled = False
        GroupBox8.Enabled = False
        txtNettIncome7Akhir.ReadOnly = True
        txtNettIncome6Akhir.ReadOnly = True
        txtNettIncome5Akhir.ReadOnly = True
        txtNettIncome4Akhir.ReadOnly = True
        txtNettIncome3Akhir.ReadOnly = True
        txtNettIncome2Akhir.ReadOnly = True
        txtNettIncome1Akhir.ReadOnly = True
        txtNettJKKAkhir.ReadOnly = True
        txtNettInsuranceAkhir.ReadOnly = True
        txtNettBasicAkhir.ReadOnly = True
        TextBox21.ReadOnly = True
        TextBox22.ReadOnly = True
        TextBox23.ReadOnly = True
        TextBox24.ReadOnly = True
        TextBox25.ReadOnly = True
        TextBox26.ReadOnly = True
        TextBox27.ReadOnly = True
        TextBox28.ReadOnly = True
        TextBox29.ReadOnly = True
        TextBox30.ReadOnly = True
        TextBox31.ReadOnly = True
        TextBox32.ReadOnly = True
        TextBox33.ReadOnly = True
        TextBox34.ReadOnly = True
        TextBox35.ReadOnly = True
        TextBox36.ReadOnly = True
        TextBox37.ReadOnly = True
        TextBox38.ReadOnly = True
        TextBox39.ReadOnly = True
        TextBox40.ReadOnly = True
        TextBox47.ReadOnly = True
        TextBox48.ReadOnly = True
        TextBox49.ReadOnly = True
        TextBox50.ReadOnly = True
        TextBox51.ReadOnly = True
        TextBox52.ReadOnly = True
        TextBox53.ReadOnly = True
        TextBox54.ReadOnly = True
        TextBox55.ReadOnly = True
        TextBox57.ReadOnly = True
        txtTaxkomponen.Text = 0
        txtTaxPembanding.Text = 0
        ComboBox1.Focus()
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox1.Enabled = False
        GroupBox7.Enabled = True
        TextBox44.Focus()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox4.Text = "" Then
            MsgBox("Bulan Mulai belum dimasukkan")
        Else
            GroupBox7.Enabled = False
            GroupBox1.Enabled = True
            CheckBox1.CheckState = CheckState.Checked
            CheckBox4.CheckState = CheckState.Checked
            CheckBox6.CheckState = CheckState.Checked
            CheckBox3.Enabled = False
            CheckBox5.Enabled = False
            TextBox1.Focus()
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call kosongkan()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        GroupBox7.Enabled = True
        GroupBox1.Enabled = True
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox5.Enabled = True
        CheckBox6.Enabled = True
        CheckBox7.Enabled = True
        CheckBox8.Enabled = True
        CheckBox9.Enabled = True
        CheckBox10.Enabled = True
        CheckBox11.Enabled = True
        CheckBox12.Enabled = True
        CheckBox13.Enabled = True
        CheckBox14.Enabled = True
        CheckBox15.Enabled = True
        CheckBox16.Enabled = True
        CheckBox17.Enabled = True
        CheckBox18.Enabled = True
        CheckBox19.Enabled = True
        CheckBox20.Enabled = True
        ComboBox1.Focus()
    End Sub

    Private Sub CheckBox1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckStateChanged
        If CheckBox2.Enabled = True Then
            CheckBox2.Enabled = False
        Else
            CheckBox2.Enabled = True
        End If
    End Sub
    Private Sub CheckBox2_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckStateChanged
        If CheckBox1.Enabled = True Then
            CheckBox1.Enabled = False
        Else
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox7_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckStateChanged
        If CheckBox8.Enabled = True Then
            CheckBox8.Enabled = False
        Else
            CheckBox8.Enabled = True
        End If
    End Sub
    Private Sub CheckBox8_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckStateChanged
        If CheckBox7.Enabled = True Then
            CheckBox7.Enabled = False
        Else
            CheckBox7.Enabled = True
        End If
    End Sub
    Private Sub CheckBox10_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckStateChanged
        If CheckBox9.Enabled = True Then
            CheckBox9.Enabled = False
        Else
            CheckBox9.Enabled = True
        End If
    End Sub
    Private Sub CheckBox9_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckStateChanged
        If CheckBox10.Enabled = True Then
            CheckBox10.Enabled = False
        Else
            CheckBox10.Enabled = True
        End If
    End Sub
    Private Sub CheckBox11_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckStateChanged
        If CheckBox12.Enabled = True Then
            CheckBox12.Enabled = False
        Else
            CheckBox12.Enabled = True
        End If
    End Sub
    Private Sub CheckBox12_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckStateChanged
        If CheckBox11.Enabled = True Then
            CheckBox11.Enabled = False
        Else
            CheckBox11.Enabled = True
        End If
    End Sub
    Private Sub CheckBox13_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckStateChanged
        If CheckBox14.Enabled = True Then
            CheckBox14.Enabled = False
        Else
            CheckBox14.Enabled = True
        End If
    End Sub
    Private Sub CheckBox14_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckStateChanged
        If CheckBox13.Enabled = True Then
            CheckBox13.Enabled = False
        Else
            CheckBox13.Enabled = True
        End If
    End Sub
    Private Sub CheckBox15_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox15.CheckStateChanged
        If CheckBox16.Enabled = True Then
            CheckBox16.Enabled = False
        Else
            CheckBox16.Enabled = True
        End If
    End Sub

    Private Sub CheckBox16_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckStateChanged
        If CheckBox15.Enabled = True Then
            CheckBox15.Enabled = False
        Else
            CheckBox15.Enabled = True
        End If
    End Sub
    Private Sub CheckBox17_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckStateChanged
        If CheckBox18.Enabled = True Then
            CheckBox18.Enabled = False
        Else
            CheckBox18.Enabled = True
        End If
    End Sub
    Private Sub CheckBox18_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckStateChanged
        If CheckBox17.Enabled = True Then
            CheckBox17.Enabled = False
        Else
            CheckBox17.Enabled = True
        End If
    End Sub
    Private Sub CheckBox19_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox19.CheckStateChanged
        If CheckBox20.Enabled = True Then
            CheckBox20.Enabled = False
        Else
            CheckBox20.Enabled = True
        End If
    End Sub
    Private Sub CheckBox20_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox20.CheckStateChanged
        If CheckBox19.Enabled = True Then
            CheckBox19.Enabled = False
        Else
            CheckBox19.Enabled = True
        End If
    End Sub


    Private Sub TextBox41_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox41.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            AsuransiSetahun = TextBox41.Text
            TextBox41.Text = Format(AsuransiSetahun, "#,###")
            ComboBox4.Focus()
        End If
    End Sub

    Private Sub TextBox44_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox44.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox45.Focus()
        End If
    End Sub

    Private Sub TextBox45_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox45.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox46.Focus()
        End If

    End Sub

    Private Sub TextBox46_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox46.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            Button4.Focus()
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Not ((e.KeyChar = Chr(84)) Or (e.KeyChar = Chr(75)) Or (e.KeyChar = Chr(47)) Or (e.KeyChar = Chr(48)) Or (e.KeyChar = Chr(49)) Or (e.KeyChar = Chr(50)) Or (e.KeyChar = Chr(51)) Or (e.KeyChar = Chr(80)) Or (e.KeyChar = Chr(72) Or (e.KeyChar = vbBack))) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = Chr(44)) Or (e.KeyChar = Chr(46)) Or (e.KeyChar = Chr(37)) Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            ComboBox3.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Focus()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Focus()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        TextBox41.Focus()
    End Sub

    Private Sub ComboBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.GotFocus

    End Sub

    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBox4.MouseClick
        AsuransiSetahun = TextBox41.Text
        TextBox41.Text = Format(AsuransiSetahun, "#,###")
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "January" Then
            SisaBulan = 12
        Else
            If ComboBox4.Text = "February" Then
                SisaBulan = 11
            Else
                If ComboBox4.Text = "March" Then
                    SisaBulan = 10
                Else
                    If ComboBox4.Text = "April" Then
                        SisaBulan = 9
                    Else
                        If ComboBox4.Text = "May" Then
                            SisaBulan = 8
                        Else
                            If ComboBox4.Text = "June" Then
                                SisaBulan = 7
                            Else
                                If ComboBox4.Text = "July" Then
                                    SisaBulan = 6
                                Else
                                    If ComboBox4.Text = "August" Then
                                        SisaBulan = 5
                                    Else
                                        If ComboBox4.Text = "September" Then
                                            SisaBulan = 4
                                        Else
                                            If ComboBox4.Text = "October" Then
                                                SisaBulan = 3
                                            Else
                                                If ComboBox4.Text = "November" Then
                                                    SisaBulan = 2
                                                Else
                                                    If ComboBox4.Text = "December" Then
                                                        SisaBulan = 1
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        TextBox42.Focus()
    End Sub

    Private Sub TextBox42_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox42.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox43.Focus()
        End If
    End Sub


    Private Sub TextBox43_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox43.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

    Sub CariJKJKKBulanan()
        JKJKKBulanan = PengaliJkJkk / SisaBulan * Val(ComboBox2.Text) / 100
        TextBox3.Text = JKJKKBulanan
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox2.Text = AsuransiSetahun / 12
            Call CariPengaliJkJkk()
            Call CariBasicSetahun()
            Call CariJKJKKBulanan()
            TextBox3.Text = JKJKKBulanan
            TextBox4.Focus()
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox7.Focus()
        End If
    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox8.Focus()
        End If
    End Sub
    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox9.Focus()
        End If
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TextBox10.Focus()
        End If
    End Sub
    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = vbBack)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            Button4.Focus()
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'If Panel3.Text = "ADMIN CLIENT SERVICE" Then
        '    frmMenuAdminMPS.Enabled = True
        '    frmMenuAdminMPS.Show()
        'Else
        '    If Panel3.Text = "CLIENT SERVICE MGR" Then
        '        frmMenuManager.Enabled = True
        '        frmMenuManager.Show()
        '    Else
        '        If Panel3.Text = "DIRECTOR" Then
        '            frmMenuManager.Enabled = True
        '            frmMenuManager.Show()
        '        End If
        '    End If
        'End If
        Me.Close()
    End Sub

    Sub CariTaxKomponenAwalLooping()
        If txtTaxPembanding.Text = 0 Then
            TaxKomponen = 0
        Else
            If txtTaxPembanding.Text <= 120000 Then
                TaxKomponen = 100
            Else
                If txtTaxPembanding.Text <= 240000 Then
                    TaxKomponen = 1000
                Else
                    If txtTaxPembanding.Text <= 360000 Then
                        TaxKomponen = 2000
                    Else
                        If txtTaxPembanding.Text <= 480000 Then
                            TaxKomponen = 3000
                        Else
                            If txtTaxPembanding.Text <= 600000 Then
                                TaxKomponen = 4000
                            Else
                                If txtTaxPembanding.Text <= 720000 Then
                                    TaxKomponen = 5000
                                Else
                                    If txtTaxPembanding.Text <= 840000 Then
                                        TaxKomponen = 6000
                                    Else
                                        If txtTaxPembanding.Text <= 960000 Then
                                            TaxKomponen = 7000
                                        Else
                                            If txtTaxPembanding.Text <= 1080000 Then
                                                TaxKomponen = 8000
                                            Else
                                                If txtTaxPembanding.Text <= 1200000 Then
                                                    TaxKomponen = 9000
                                                Else
                                                    If txtTaxPembanding.Text <= 1500000 Then
                                                        TaxKomponen = 10000
                                                    Else
                                                        If txtTaxPembanding.Text <= 3000000 Then
                                                            TaxKomponen = 125000
                                                        Else
                                                            If txtTaxPembanding.Text <= 5000000 Then
                                                                TaxKomponen = 250000
                                                            Else
                                                                If txtTaxPembanding.Text <= 9000000 Then
                                                                    TaxKomponen = 400000
                                                                Else
                                                                    If txtTaxPembanding.Text <= 20000000 Then
                                                                        TaxKomponen = 750000
                                                                    Else
                                                                        If txtTaxPembanding.Text <= 50000000 Then
                                                                            TaxKomponen = 1650000
                                                                        Else
                                                                            If txtTaxPembanding.Text <= 75000000 Then
                                                                                TaxKomponen = 4100000
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox56.Text = SisaBulan
        Call CariPengaliJkJkk()
        Call CariPTKP()
        txtPTKP.Text = Format(PTKP, "#,###")
        Call CariPercent()
        Call CariNett()

        '========================************TESTING Prosedur CARI NETT SETAHUN********************================
        '========================************TESTING Prosedur CARI NETT SETAHUN********************================
        txtNettBasic.Text = NettBasic
        txtNettInsurance.Text = NettInsurance
        txtNettJKK.Text = NettJKK
        txtNettIncome1.Text = NettIncome1
        txtNettIncome2.Text = NettIncome2
        txtNettIncome3.Text = NettIncome3
        txtNettIncome4.Text = NettIncome4
        txtNettIncome5.Text = NettIncome5
        txtNettIncome6.Text = NettIncome6
        txtNettIncome7.Text = NettIncome7
        Call CariBasicSetahun()
        Call TotalNettSementara()
        Call CariBiayaJabatan()
        Call CariPKP()
        Call HitungPajak()
        txtTaxPembanding.Text = TaxPembanding
        'UseWaitCursor = True
    End Sub
    Sub Wait()
        'Timer3.Enabled = True
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call Wait()
        Call CariTaxKomponenAwalLooping()
        Do Until TaxPembanding - 12 * TaxKomponen < 100
            TaxKomponen = TaxKomponen * 1.00025
            Call CariPercent()
            Call CariNett()
            Call CariPTKP()
            Call CariBasicSetahun()
            Call TotalNettSementara()
            Call CariBiayaJabatan()
            Call CariPengaliJkJkk()
            Call CariPKP()
            Call HitungPajak()
            txtTaxPembanding.Text = TaxPembanding
            txtTaxkomponen.Text = TaxKomponen * 12
            'txtNettBasicAkhir.Text = NettBasic / 12
            txtNettBasicAkhir.Text = Format(NettBasic / SisaBulan, "#,###")
            'txtNettInsuranceAkhir.Text = NettInsurance / 12
            txtNettInsuranceAkhir.Text = Format(NettInsurance / SisaBulan, "#,###")
            'txtNettJKKAkhir.Text = NettJKK / 12
            txtNettJKKAkhir.Text = Format(NettJKK / SisaBulan, "#,###")
            'txtNettIncome1Akhir.Text = NettIncome1 / 12
            txtNettIncome1Akhir.Text = Format(NettIncome1 / SisaBulan, "#,###")
            'txtNettIncome2Akhir.Text = NettIncome2 / 12
            txtNettIncome2Akhir.Text = Format(NettIncome2 / SisaBulan, "#,###")
            'txtNettIncome3Akhir.Text = NettIncome3 / 12
            txtNettIncome3Akhir.Text = Format(NettIncome3 / SisaBulan, "#,###")
            'txtNettIncome4Akhir.Text = NettIncome4 / 12
            txtNettIncome4Akhir.Text = Format(NettIncome4 / SisaBulan, "#,###")
            'txtNettIncome5Akhir.Text = NettIncome5 / 12
            txtNettIncome5Akhir.Text = Format(NettIncome5 / SisaBulan, "#,###")
            'txtNettIncome6Akhir.Text = NettIncome6 / 12
            txtNettIncome6Akhir.Text = Format(NettIncome6 / SisaBulan, "#,###")
            'txtNettIncome7Akhir.Text = NettIncome7 / 12
            txtNettIncome7Akhir.Text = Format(NettIncome7 / SisaBulan, "#,###")
            TextBox30.Text = Format(TaxKomponen * PercentBasic, "#,###")
            TextBox29.Text = Format(TaxKomponen * PercentInsurance, "#,###")
            TextBox28.Text = Format(TaxKomponen * PercentJKK, "#,###")
            TextBox27.Text = Format(TaxKomponen * PercentIncome1, "#,###")
            TextBox26.Text = Format(TaxKomponen * PercentIncome2, "#,###")
            TextBox25.Text = Format(TaxKomponen * PercentIncome3, "#,###")
            TextBox24.Text = Format(TaxKomponen * PercentIncome4, "#,###")
            TextBox23.Text = Format(TaxKomponen * PercentIncome5, "#,###")
            TextBox22.Text = Format(TaxKomponen * PercentIncome6, "#,###")
            TextBox21.Text = Format(TaxKomponen * PercentIncome7, "#,###")

            TextBox40.Text = Format((NettBasic / SisaBulan) + (TaxKomponen * PercentBasic), "#,###")
            TextBox39.Text = Format((NettInsurance / SisaBulan) + (TaxKomponen * PercentInsurance), "#,###")
            TextBox38.Text = Format((NettJKK / SisaBulan) + (TaxKomponen * PercentJKK), "#,###")
            TextBox37.Text = Format((NettIncome1 / SisaBulan) + (TaxKomponen * PercentIncome1), "#,###")
            TextBox36.Text = Format((NettIncome2 / SisaBulan) + (TaxKomponen * PercentIncome2), "#,###")
            TextBox35.Text = Format((NettIncome3 / SisaBulan) + (TaxKomponen * PercentIncome3), "#,###")
            TextBox34.Text = Format((NettIncome4 / SisaBulan) + (TaxKomponen * PercentIncome4), "#,###")
            TextBox33.Text = Format((NettIncome5 / SisaBulan) + (TaxKomponen * PercentIncome5), "#,###")
            TextBox32.Text = Format((NettIncome6 / SisaBulan) + (TaxKomponen * PercentIncome6), "#,###")
            TextBox31.Text = Format((NettIncome7 / SisaBulan) + (TaxKomponen * PercentIncome7), "#,###")
            TextBox57.Text = Format(TaxKomponen, "#,###")
            txtTHP.Text = Format((NettBasic / SisaBulan) + (TaxKomponen * PercentBasic) + (NettIncome1 / SisaBulan) + (TaxKomponen * PercentIncome1) + (NettIncome2 / SisaBulan) + (TaxKomponen * PercentIncome2) + (NettIncome3 / SisaBulan) + (TaxKomponen * PercentIncome3) + (NettIncome4 / SisaBulan) + (TaxKomponen * PercentIncome4) + (NettIncome5 / SisaBulan) + (TaxKomponen * PercentIncome5) + (NettIncome6 / SisaBulan) + (TaxKomponen * PercentIncome6) + (NettIncome7 / SisaBulan) + (TaxKomponen * PercentIncome7) - (Val(txtJHT.Text) / SisaBulan) - TaxKomponen, "#,###")
        Loop
        GroupBox6.Enabled = True
    End Sub
    Sub CariPercent()
        '============Nilai Total sementara adalah nilai inputan textbox campur nett & gross===================
        '============ini nyari persentasi kasar aja===================
        TotalSementara = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text)
        PercentBasic = Val(TextBox1.Text) / TotalSementara
        PercentInsurance = Val(TextBox2.Text) / TotalSementara
        PercentJKK = Val(TextBox3.Text) / TotalSementara
        PercentIncome1 = Val(TextBox4.Text) / TotalSementara
        PercentIncome2 = Val(TextBox5.Text) / TotalSementara
        PercentIncome3 = Val(TextBox6.Text) / TotalSementara
        PercentIncome4 = Val(TextBox7.Text) / TotalSementara
        PercentIncome5 = Val(TextBox8.Text) / TotalSementara
        PercentIncome6 = Val(TextBox9.Text) / TotalSementara
        PercentIncome7 = Val(TextBox10.Text) / TotalSementara
    End Sub
    Sub CariBasicSetahun()
        If CheckBox1.CheckState = CheckState.Checked Then
            BasicSetahun = SisaBulan * Val(TextBox1.Text)
        Else
            BasicSetahun = SisaBulan * (Val(TextBox1.Text) + PercentBasic * TaxKomponen)
        End If
    End Sub
    Sub CariNett()
        If CheckBox2.CheckState = CheckState.Checked Then
            NettBasic = SisaBulan * Val(TextBox1.Text)
        Else
            NettBasic = SisaBulan * (Val(TextBox1.Text) - PercentBasic * TaxKomponen)
        End If

        If CheckBox3.CheckState = CheckState.Checked Then
            NettInsurance = SisaBulan * Val(TextBox2.Text)
        Else
            NettInsurance = SisaBulan * (Val(TextBox2.Text) - PercentInsurance * TaxKomponen)
        End If

        If CheckBox5.CheckState = CheckState.Checked Then
            NettJKK = SisaBulan * Val(TextBox3.Text)
        Else
            NettJKK = SisaBulan * (Val(TextBox3.Text) - PercentJKK * TaxKomponen)
        End If

        If CheckBox7.CheckState = CheckState.Checked Then
            NettIncome1 = SisaBulan * Val(TextBox4.Text)
        Else
            NettIncome1 = SisaBulan * (Val(TextBox4.Text) - PercentIncome1 * TaxKomponen)
        End If

        If CheckBox9.CheckState = CheckState.Checked Then
            NettIncome2 = SisaBulan * Val(TextBox5.Text)
        Else
            NettIncome2 = SisaBulan * (Val(TextBox5.Text) - PercentIncome2 * TaxKomponen)
        End If

        If CheckBox11.CheckState = CheckState.Checked Then
            NettIncome3 = SisaBulan * Val(TextBox6.Text)
        Else
            NettIncome3 = SisaBulan * (Val(TextBox6.Text) - PercentIncome3 * TaxKomponen)
        End If

        If CheckBox13.CheckState = CheckState.Checked Then
            NettIncome4 = SisaBulan * Val(TextBox7.Text)
        Else
            NettIncome4 = SisaBulan * (Val(TextBox7.Text) - PercentIncome4 * TaxKomponen)
        End If

        If CheckBox15.CheckState = CheckState.Checked Then
            NettIncome5 = SisaBulan * Val(TextBox8.Text)
        Else
            NettIncome5 = SisaBulan * (Val(TextBox8.Text) - PercentIncome5 * TaxKomponen)
        End If

        If CheckBox17.CheckState = CheckState.Checked Then
            NettIncome6 = SisaBulan * Val(TextBox9.Text)
        Else
            NettIncome6 = SisaBulan * (Val(TextBox9.Text) - PercentIncome6 * TaxKomponen)
        End If

        If CheckBox19.CheckState = CheckState.Checked Then
            NettIncome7 = SisaBulan * Val(TextBox10.Text)
        Else
            NettIncome7 = SisaBulan * (Val(TextBox10.Text) - PercentIncome7 * TaxKomponen)
        End If

    End Sub
    '=======================Check PTKP======================================
    '=======================Check PTKP======================================
    'Harus pakai mekanisme liat referensi
    Sub CariPTKP()
        If ComboBox1.Text = "TK/0" Then
            PTKP = 24300000
        Else
            If ComboBox1.Text = "TK/1" Then
                PTKP = 26325000
            Else
                If ComboBox1.Text = "TK/2" Then
                    PTKP = 28350000
                Else
                    If ComboBox1.Text = "TK/3" Then
                        PTKP = 30375000
                    Else
                        If ComboBox1.Text = "K/0" Then
                            PTKP = 26325000
                        Else
                            If ComboBox1.Text = "K/1" Then
                                PTKP = 28350000
                            Else
                                If ComboBox1.Text = "K/2" Then
                                    PTKP = 30375000
                                Else
                                    If ComboBox1.Text = "K/3" Then
                                        PTKP = 32400000
                                    Else
                                        If ComboBox1.Text = "PH/0" Then
                                            PTKP = 48600000
                                        Else
                                            If ComboBox1.Text = "PH/1" Then
                                                PTKP = 50625000
                                            Else
                                                If ComboBox1.Text = "PH/2" Then
                                                    PTKP = 52650000
                                                Else
                                                    If ComboBox1.Text = "PH/3" Then
                                                        PTKP = 54675000
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Sub TotalNettSementara()
        TotalNett = NettBasic + NettInsurance + NettJKK + NettIncome1 + NettIncome2 + NettIncome3 + NettIncome4 + NettIncome5 + NettIncome6 + NettIncome7
    End Sub

    Sub CariBiayaJabatan()
        If (TotalNett + (12 * TaxKomponen)) * 0.05 > 6000000 Then
            BiayaJabatan = 6000000
        Else
            BiayaJabatan = (TotalNett + SisaBulan * (TaxKomponen)) * 0.05
        End If
        txtBiayaJabatan.Text = BiayaJabatan
    End Sub
    Sub CariPKP()
        TotalSementaraPlusSBLM = TotalNett + Val(TextBox42.Text) + SisaBulan * TaxKomponen
        txtTotal.Text = TotalSementaraPlusSBLM
        If TotalSementaraPlusSBLM - PTKP - (0.02 * PengaliJkJkk) - BiayaJabatan > 0 Then
            PKP = TotalSementaraPlusSBLM - PTKP - (0.02 * PengaliJkJkk) - BiayaJabatan
        Else
            PKP = 0
        End If
        txtPKP.Text = PKP
        txtJHT.Text = 0.02 * PengaliJkJkk
    End Sub
    Sub CariPengaliJkJkk()
        If ComboBox3.Text = "Basic Salary" Then
            PengaliJkJkk = BasicSetahun
        Else
            PengaliJkJkk = NettBasic + NettInsurance + NettIncome1 + NettIncome2 + NettIncome3 + NettIncome4 + NettIncome5 + NettIncome6 + NettIncome7 + SisaBulan * TaxKomponen - (SisaBulan * PercentJKK * TaxKomponen)
        End If
    End Sub
    Sub HitungPajak()
        If PKP <= 50000000 Then
            TaxPembanding = 0.05 * PKP
        Else
            If PKP <= 250000000 And PKP > 50000000 Then
                TaxPembanding = 2500000 + (0.15 * (PKP - 50000000))
            Else
                If PKP <= 500000000 And PKP > 250000000 Then
                    TaxPembanding = 32500000 + (0.25 * (PKP - 250000000))
                Else
                    If PKP >= 500000000 Then
                        TaxPembanding = 95000000 + (0.3 * (PKP - 500000000))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox2.Text = AsuransiSetahun / 12
        Call CariPengaliJkJkk()
        Call CariBasicSetahun()
        Call CariJKJKKBulanan()
        TextBox3.Text = JKJKKBulanan
        TextBox4.Focus()
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        UseWaitCursor = False
        Timer1.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer3.Tick
        'Pic1.Visible = True
        'Pic1.Image = New System.Drawing.Bitmap("wait1.png")
        'Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer4.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait2.png")
        'Timer3.Enabled = False
        'Timer5.Enabled = True
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer5.Tick
        ' Pic1.Image = New System.Drawing.Bitmap("wait3.png")
        'Timer4.Enabled = False
        'Timer6.Enabled = True
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer6.Tick
        ' Pic1.Image = New System.Drawing.Bitmap("wait4.png")
        'Timer5.Enabled = False
        'Timer7.Enabled = True
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer7.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait5.png")
        'Timer6.Enabled = False
        'Timer8.Enabled = True
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer8.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait6.png")
        'Timer7.Enabled = False
        'Timer9.Enabled = True
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer9.Tick
        ' Pic1.Image = New System.Drawing.Bitmap("wait7.png")
        'Timer8.Enabled = False
        'Timer10.Enabled = True
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer10.Tick
        ' Pic1.Image = New System.Drawing.Bitmap("wait8.png")
        'Timer9.Enabled = False
        'Timer11.Enabled = True
    End Sub

    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer11.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait9.png")
        'Timer10.Enabled = False
        'Timer12.Enabled = True
    End Sub

    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer12.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait10.png")
        'Timer11.Enabled = False
        'Timer13.Enabled = True
    End Sub

    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer13.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait11.png")
        'Timer12.Enabled = False
        'Timer14.Enabled = True
    End Sub

    Private Sub Timer14_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer14.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait12.png")
        'Timer13.Enabled = False
        'Timer15.Enabled = True
    End Sub

    Private Sub Timer15_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer15.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait13.png")
        'Timer14.Enabled = False
        'Timer16.Enabled = True
    End Sub

    Private Sub Timer16_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer16.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait14.png")
        'Timer15.Enabled = False
        'Timer17.Enabled = True
    End Sub

    Private Sub Timer17_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer17.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait15.png")
        'Timer16.Enabled = False
        'Timer18.Enabled = True
    End Sub

    Private Sub Timer18_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer18.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait16.png")
        'Timer17.Enabled = False
        'Timer19.Enabled = True
    End Sub

    Private Sub Timer19_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer19.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait17.png")
        'Timer18.Enabled = False
        'Timer20.Enabled = True
    End Sub

    Private Sub Timer20_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer20.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait18.png")
        'Timer19.Enabled = False
        'Timer21.Enabled = True
    End Sub

    Private Sub Timer21_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer21.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait19.png")
        'Timer20.Enabled = False
        'Timer22.Enabled = True
    End Sub

    Private Sub Timer22_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer22.Tick
        'Pic1.Image = New System.Drawing.Bitmap("wait20.png")
        'Timer21.Enabled = False
        'Timer23.Enabled = True
    End Sub

    Private Sub Timer23_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Timer23.Tick
        UseWaitCursor = False
        'Timer22.Enabled = False
        'Pic1.Visible = False
        'Timer23.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox41_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox41.TextChanged

    End Sub
End Class