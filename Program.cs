using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PLC_Basic
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
        }
    }

    public class Other
    {
        /*
        private void btn_Open_Click(object sender, EventArgs e)
        {
            int iReturnCode;                //Return code
            int iLogicalStationNumber;      //LogicalStationNumber for ActUtlType

            //Displayed output data is cleared.
            ClearDisplay();

            //
            //Processing of Open method
            //
            try
            {
                //When ActProgType is selected by the radio button,
                if (rad_ActProgType.Checked)
                {
                    //Set the value of 'UnitType' to the property(UNIT_QNUSB).
                    axActProgType1.ActUnitType = 0x16;
                    //Set the value of 'ProtocolType' to the property(PROTOCOL_USB).
                    axActProgType1.ActProtocolType = 0x0D;
                    //Set the value of 'Password'.
                    axActProgType1.ActPassword = txt_Password.Text;
                    //The Open method is executed.
                    iReturnCode = axActProgType1.Open();
                    //When the Open method is succeeded, make the EventHandler of ActProgType Controle.
                    if (iReturnCode == 0)
                    {
                        txt_LogicalStationNumber.Enabled = false;
                    }
                }

                //When ActUtlType is selected by the radio button,
                else
                {
                    //Check the 'LogicalStationNumber'.(If succeeded, the value is gotten.)
                    if (GetIntValue(txt_LogicalStationNumber, out iLogicalStationNumber) != true)
                    {
                        //If failed, this process is end.           
                        return;
                    }

                    //Set the value of 'LogicalStationNumber' to the property.
                    axActUtlType1.ActLogicalStationNumber = iLogicalStationNumber;

                    //Set the value of 'Password'.
                    axActUtlType1.ActPassword = txt_Password.Text;

                    //The Open method is executed.
                    iReturnCode = axActUtlType1.Open();
                    //When the Open method is succeeded, disable the TextBox of 'LogocalStationNumber'.
                    //When the Open method is succeeded, make the EventHandler of ActUtlType Controle.
                    if (iReturnCode == 0)
                    {
                        txt_LogicalStationNumber.Enabled = false;
                    }
                }

            }
            //Exception processing
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                                  Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode);
        }
#endregion

        #region  "Processing of Close button"
        private void btn_Close_Click(object sender, EventArgs e)
        {
            int iReturnCode;    //Return code

            //Displayed output data is cleared.
            ClearDisplay();

            //
            //Processing of Close method
            //
            try
            {
                //When ActProgType is selected by the radio button,
                if (rad_ActProgType.Checked)
                {
                    //The Close method is executed.
                    iReturnCode = axActProgType1.Close();
                }

                //When ActUtlType is selected by the radio button,
                else
                {
                    //The Close method is executed.
                    iReturnCode = axActUtlType1.Close();

                    //When The Close method is succeeded, enable the TextBox of 'LogocalStationNumber'.
                    if (iReturnCode == 0)
                    {
                        txt_LogicalStationNumber.Enabled = true;
                    }
                }

            }

            //Exception processing
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                                  Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode);

        }
        #endregion

        #region  "Processing of ReadDeviceRandom2 button"
        private void btn_ReadDeviceRandom2_Click(object sender, EventArgs e)
        {
            int iReturnCode;                //Return code
            String szDeviceName = "";       //List data for 'DeviceName'
            int iNumberOfData = 0;          //Data for 'DeviceSize'
            short[] arrDeviceValue;         //Data for 'DeviceValue
            int iNumber;                    //Loop counter
            System.String[] arrData;        //Array for 'Data'

            //Displayed output data is cleared.
            ClearDisplay();

            //Get the list of 'DeviceName'.
            //  Join each line(StringType array) of 'DeviceName' by the separator '\n',
            //  and create a joined string data.
            szDeviceName = String.Join("\n", txt_DeviceNameRandom.Lines);

            //Check the 'DeviceSize'.(If succeeded, the value is gotten.)
            if (!GetIntValue(txt_DeviceSizeRandom, out iNumberOfData))
            {
                //If failed, this process is end.
                return;
            }

            //Assign the array for 'DeviceValue'.
            arrDeviceValue = new short[iNumberOfData];

            //
            //Processing of ReadDeviceRandom2 method
            //
            try
            {
                //When ActProgType is selected by the radio button,
                if (rad_ActProgType.Checked)
                {
                    //The ReadDeviceRandom2 method is executed.
                    iReturnCode = axActProgType1.ReadDeviceRandom2(szDeviceName,
                                                                    iNumberOfData,
                                                                    out arrDeviceValue[0]);
                }

                //When ActUtlType is selected by the radio button,
                else
                {
                    //The ReadDeviceRandom2 method is executed.
                    iReturnCode = axActUtlType1.ReadDeviceRandom2(szDeviceName,
                                                                    iNumberOfData,
                                                                    out arrDeviceValue[0]);
                }
            }

            //Exception processing
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8}", iReturnCode);

            //
            //Display the read data
            //
            //When the ReadDeviceRandom2 method is succeeded, display the read data.
            if (iReturnCode == 0)
            {
                //Assign the array for the read data.
                arrData = new System.String[iNumberOfData];

                //Copy the read data to the 'arrData'.
                for (iNumber = 0; iNumber < iNumberOfData; iNumber)
                {

                    arrData[iNumber] = arrDeviceValue[iNumber].ToString();

                }
                //Set the read data to the 'Data', and display it.
                txt_Data.Lines = arrData;
            }

        }
        #endregion

        #region "Processing of WriteDeviceRandom2 button"
        private void btn_WriteDeviceRandom2_Click(object sender, EventArgs e)
        {
            int iReturnCode;                //Return code
            String szDeviceName = "";       //List data for 'DeviceName'
            int iNumberOfData = 0;          //Data for 'DeviceSize'
            short[] arrDeviceValue;         //Data for 'DeviceValue'
            int iNumber;                    //Loop counter


            //Displayed output data is cleared.
            ClearDisplay();

            //Get the list of 'DeviceName'.
            //  Join each line(StringType array) of 'DeviceName' by the separator '\n',
            //  and create a joined string data.
            szDeviceName = String.Join("\n", txt_DeviceNameRandom.Lines);

            //Check the 'DeviceSize'.(If succeeded, the value is gotten.)
            if (!GetIntValue(txt_DeviceSizeRandom, out iNumberOfData))
            {
                //If failed, this process is end.
                return;
            }

            //Check the 'DeviceValue'.(If succeeded, the value is gotten.)
            arrDeviceValue = new short[iNumberOfData];
            if (!GetShortArray(txt_DeviceDataRandom, out arrDeviceValue))
            {
                //If failed, this process is end.
                return;
            }

            //Set the 'DeviceVale'.
            for (iNumber = 0; iNumber < iNumberOfData; iNumber)
            {
                arrDeviceValue[iNumber] = arrDeviceValue[iNumber];
            }

            //
            //Processing of WriteDeviceRandom2 method
            //
            try
            {
                //When ActProgType is selected by the radio button,
                if (rad_ActProgType.Checked)
                {
                    //The WriteDeviceRandom2 method is executed.
                    iReturnCode = axActProgType1.WriteDeviceRandom2(szDeviceName,
                                                                  iNumberOfData,
                                                                  ref arrDeviceValue[0]);
                }

                //When ActUtlType is selected by the radio button,
                else
                {
                    //The WriteDeviceRandom2 method is executed.
                    iReturnCode = axActUtlType1.WriteDeviceRandom2(szDeviceName,
                                                                  iNumberOfData,
                                                                  ref arrDeviceValue[0]);
                }
            }

            //Exception processing          
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8}", iReturnCode);

        }
        #endregion

        #region "Processing of ReadDeviceBlock2 button"
        private void btn_ReadDeviceBlock2_Click(object sender, EventArgs e)
        {
            int iReturnCode;                //Return code
            String szDeviceName = "";       //List data for 'DeviceName'
            int iNumberOfData = 0;          //Data for 'iNumberOfData'
            short[] arrDeviceValue;         //Data for 'DeviceValue'
            int iNumber;                    //Loop counter
            System.String[] arrData;        //Array for 'Data'


            //Displayed output data is cleared.
            ClearDisplay();

            //Get the list of 'DeviceName'.
            //  Join each line(StringType array) of 'DeviceName' by the separator '\n',
            //  and create a joined string data.
            szDeviceName = String.Join("\n", txt_DeviceNameBlock.Lines);

            //Check the 'DeviceSize'.(If succeeded, the value is gotten.)
            if (!GetIntValue(txt_DeviceSizeBlock, out iNumberOfData))
            {
                //If failed, this process is end.
                return;
            }

            //Assign the array for 'DeviceValue'.
            arrDeviceValue = new short[iNumberOfData];

            //
            //Processing of ReadDeviceBlock2 method
            //
            try
            {
                //When ActProgType is selected by the radio button,
                if (rad_ActProgType.Checked)
                {
                    //The ReadDeviceBlock2 method is executed.
                    iReturnCode = axActProgType1.ReadDeviceBlock2(szDeviceName,
                                                                 iNumberOfData,
                                                                 out arrDeviceValue[0]);
                }

                //When ActUtlType is selected by the radio button,
                else
                {
                    //The ReadDeviceBlock2 method is executed.
                    iReturnCode = axActUtlType1.ReadDeviceBlock2(szDeviceName,
                                                                 iNumberOfData,
                                                                 out arrDeviceValue[0]);
                }
            }

            //Exception processing          
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8}", iReturnCode);

            //
            //Display the read data
            //
            //When the ReadDeviceBlock2 method is succeeded, display the read data.
            if (iReturnCode == 0)
            {
                //Assign array for the read data.
                arrData = new System.String[iNumberOfData];

                //Copy the read data to the 'arrData'.
                for (iNumber = 0; iNumber < iNumberOfData; iNumber)
                {
                    arrData[iNumber] = arrDeviceValue[iNumber].ToString();
                }

                //Set the read data to the 'Data', and display it.
                txt_Data.Lines = arrData;
            }

        }
        #endregion

        #region "Processing of WriteDeviceBlock2 button"
        private void btn_WriteDeviceBlock2_Click(object sender, EventArgs e)
        {
            int iReturnCode;                //Return code
            String szDeviceName = "";       //List data for 'DeviceName'
            int iNumberOfData = 0;          //Data for 'DeviceSize'
            short[] arrDeviceValue;         //Data for 'DeviceValue'
            int iNumber;                    //Loop counter
            int iSizeOfIntArray;            //


            //Displayed output data is cleared.
            ClearDisplay();

            //Get the list of 'DeviceName'.
            //  Join each line(StringType array) of 'DeviceName' by the separator '\n',
            //  and create a joined string data.
            szDeviceName = String.Join("\n", txt_DeviceNameBlock.Lines);

            //Check the 'DeviceSize'.(If succeeded, the value is gotten.)
            if (!GetIntValue(txt_DeviceSizeBlock, out iNumberOfData))
            {
                //If failed, this process is end.
                return;
            }

            //Get size for 'DeviceValue'
            iSizeOfIntArray = txt_DeviceDataBlock.Lines.Length;
            //Assign the array for 'DeviceValue'.
            arrDeviceValue = new short[iNumberOfData];

            //Convert the 'DeviceValue'.
            for (iNumber = 0; iNumber < iSizeOfIntArray; iNumber)
            {
                try
                {
                    arrDeviceValue[iNumber]
                        = Convert.ToInt16(txt_DeviceDataBlock.Lines[iNumber]);
                }

                //Exception processing
                catch (Exception exExcepion)
                {
                    MessageBox.Show(exExcepion.Message,
                                      Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //
            //Processing of WriteDeviceBlock2 method
            //
            try
            {
                //When ActProgType is selected by the radio button,
                if (rad_ActProgType.Checked)
                {
                    //The WriteDeviceRandom2 method is executed.
                    iReturnCode = axActProgType1.WriteDeviceBlock2(szDeviceName,
                                                                    iNumberOfData,
                                                                    ref arrDeviceValue[0]);
                }

                //When ActUtlType is selected by the radio button,
                else
                {
                    //The WriteDeviceRandom2 method is executed.
                    iReturnCode = axActUtlType1.WriteDeviceBlock2(szDeviceName,
                                                                    iNumberOfData,
                                                                    ref arrDeviceValue[0]);
                }
            }

            //Exception processing          
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode);

        }
        #endregion

        #region "Processing of  EntryDeviceStatus button"
        private void btn_EntryDeviceStatus_Click(object sender, EventArgs e)
        {
            int iReturnCode;                //Return code
            String szDeviceName = "";       //List data for 'DeviceName'
            int iNumberOfData = 0;          //Data for 'DeviceSize'
            int iMonitorCycle = 0;          //Data for 'MonitorCycle'
            int[] arrDeviceValue;           //Data for 'DeviceValue'


            //Displayed output data is cleared.
            ClearDisplay();

            //Get the list of 'DeviceName'.
            //  Join each line(StringType array) of 'DeviceName' by the separator '\n',
            //  and create a joined string data.
            szDeviceName = String.Join("\n", txt_DeviceNameStatus.Lines);

            //Check the 'DeviceSize'.(If succeeded, the value is gotten.)
            if (!GetIntValue(txt_DeviceSizeStatus, out iNumberOfData))
            {
                //If failed, this process is end.
                return;
            }

            //Check the 'MonitorCycle'.(If succeeded, the value is gotten.)
            if (!GetIntValue(txt_MonitorCycleStatus, out iMonitorCycle))
            {
                //If failed, this process is end.
                return;
            }

            //Check the 'DeviceValue'.(If succeeded, the value is gotten.)
            arrDeviceValue = new int[iNumberOfData];
            if (!GetIntArray(txt_DeviceDataStatus, out arrDeviceValue))
            {
                //If failed, this process is end.
                return;
            }


            //
            //Processing of EntryDeviceStatus method
            //
            try
            {
                //When ActProgType is selected by the radio button,
                if (rad_ActProgType.Checked)
                {
                    //The EntryDeviceStatus method is executed.
                    iReturnCode = axActProgType1.EntryDeviceStatus(szDeviceName,
                                                                    iNumberOfData,
                                                                    iMonitorCycle,
                                                                    ref arrDeviceValue[0]);
                }

                //When ActUtlType is selected by the radio button,
                else
                {
                    //The EntryDeviceStatus method is executed.
                    iReturnCode = axActUtlType1.EntryDeviceStatus(szDeviceName,
                                                                    iNumberOfData,
                                                                    iMonitorCycle,
                                                                    ref arrDeviceValue[0]);
                }
            }

            //Exception processing          
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode);


        }
        #endregion

        #region "Processing of FreeDeviceStatus button  "
        private void btn_FreeDeviceStatus_Click(object sender, EventArgs e)
        {
            int iReturnCode;    //Return code

            //Displayed output data is cleared.
            ClearDisplay();

            //
            //Processing of FreeDeviceStatus method
            //
            try
            {
                //When ActProgType is selected by the radio button,
                if (rad_ActProgType.Checked)
                {
                    //The FreeDeviceStatus method is executed.
                    iReturnCode = axActProgType1.FreeDeviceStatus();
                }

                //When ActUtlType is selected by the radio button,
                else
                {
                    //The FreeDeviceStatus method is executed.
                    iReturnCode = axActUtlType1.FreeDeviceStatus();
                }
            }

            //Exception processing
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                                  Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode);


        }
        #endregion

        #region "Processing of OnDeviceStatus for ActUtlType Controle"
        private void ActUtlType1_OnDeviceStatus(System.Object sender, AxActUtlTypeLib._IActUtlTypeEvents_OnDeviceStatusEvent e)
        {
            System.String[] arrData;
            //Assign the array for editing the data of 'Data'.
            arrData = new System.String[txt_Data.Lines.Length   1];

            //Set the lateset data of 'Data' to arrData.
            Array.Copy(txt_Data.Lines, arrData, txt_Data.Lines.Length);

            //Add the content of new event to arrData.
            arrData[txt_Data.Lines.Length]
            = String.Format("OnDeviceStatus event by ActUtlType [{0}={1}]", e.szDevice, e.lData);

            //The new 'Data' is displayed.
            txt_Data.Lines = arrData;

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8}", e.lReturnCode);

        }
        #endregion

        #region "Processing of OnDeviceStatus for ActProgType Controle"
        private void ActProgType1_OnDeviceStatus(System.Object sender, AxActProgTypeLib._IActProgTypeEvents_OnDeviceStatusEvent e)
        {
            System.String[] arrData;
            //Assign the array for editing the data of 'Data'.
            arrData = new System.String[txt_Data.Lines.Length   1];

            //Set the lateset data of 'Data' to arrData.
            Array.Copy(txt_Data.Lines, arrData, txt_Data.Lines.Length);

            //Add the content of new event to arrData.
            arrData[txt_Data.Lines.Length]
            = String.Format("OnDeviceStatus event by ActProgType [{0}={1}]", e.szDevice, e.lData);

            //The new 'Data' is displayed.
            txt_Data.Lines = arrData;

            //The return code of the method is displayed by the hexadecimal.
            txt_ReturnCode.Text = String.Format("0x{0:x8}", e.lReturnCode);

        }
        #endregion

        #region "Processing of getting ShortType array from StringType array of multiline TextBox"

        private bool GetShortArray(TextBox lptxt_SourceOfShortArray, out short[] lplpshShortArrayValue)
        {
            int iSizeOfShortArray;      //Size of ShortType array
            int iNumber;                //Loop counter

            //Get the size of ShortType array.
            iSizeOfShortArray = lptxt_SourceOfShortArray.Lines.Length;
            lplpshShortArrayValue = new short[iSizeOfShortArray];

            //Get each element of ShortType array.
            for (iNumber = 0; iNumber < iSizeOfShortArray; iNumber)
            {
                try
                {
                    lplpshShortArrayValue[iNumber]
                        = Convert.ToInt16(lptxt_SourceOfShortArray.Lines[iNumber]);
                }

                //When the value is nothing or out of the range, the exception is processed.
                catch (Exception exExcepion)
                {
                    MessageBox.Show(exExcepion.Message,
                                      Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            //Normal End
            return true;
        }

        #endregion


        #region "Processing of getting IntType array from StringType array of multiline TextBox"

        private bool GetIntArray(TextBox lptxt_SourceOfIntArray, out int[] lplpiIntArrayValue)
        {
            int iSizeOfIntArray;        //Size of IntType array
            int iNumber;                //Loop counter

            //Get the size of IntType array.
            iSizeOfIntArray = lptxt_SourceOfIntArray.Lines.Length;
            lplpiIntArrayValue = new int[iSizeOfIntArray];

            //Get each element of IntType array.
            for (iNumber = 0; iNumber < iSizeOfIntArray; iNumber)
            {
                try
                {
                    lplpiIntArrayValue[iNumber]
                        = Convert.ToInt32(lptxt_SourceOfIntArray.Lines[iNumber]);
                }

                //When the value is nothing or out of the range, the exception is processed.
                catch (Exception exExcepion)
                {
                    MessageBox.Show(exExcepion.Message,
                                      Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            //Normal End
            return true;
        }

        #endregion


        #region "Processing of getting 32bit integer from TextBox"

        private bool GetIntValue(TextBox lptxt_SourceOfIntValue, out int iGottenIntValue)
        {
            iGottenIntValue = 0;
            //Get the value as 32bit integer from a TextBox
            try
            {
                iGottenIntValue = Convert.ToInt32(lptxt_SourceOfIntValue.Text);
            }

            //When the value is nothing or out of the range, the exception is processed.
            catch (Exception exExcepion)
            {
                MessageBox.Show(exExcepion.Message,
                                  Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Normal End
            return true;
        }

        #endregion


        #region "Processing of clear displayed output data"
        private void ClearDisplay()
        {
            //Clear TextBox of 'ReturnCode','Data'
            txt_ReturnCode.Text = "";
            txt_Data.Text = "";
        }
        #endregion
        */
    }
}
