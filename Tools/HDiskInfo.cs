using System;
using System.Runtime.InteropServices;

namespace GetDiskInfo
{

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct DiskInfo
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public string SerialNumber;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=40)]
		public string ModelNumber;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=9)]
		public string FirmwareRev;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=10)]
		public string InterfaceType;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=40)]
		public string MediaType;
		public int BufferSize;
		public int Cylinders;
		public int Heads;
		public int Sectors;
        public int SectorsPerTrack;
        public int BytesPerSector;

        public DiskInfo(string SerialNumber, string ModelNumber, string FirmwareRev, string InterfaceType, string MediaType, int BufferSize, int Cylinders, int Heads, int Sectors, int SectorsPerTrack, int BytesPerSector)
		{
			this.SerialNumber = SerialNumber;
			this.ModelNumber = ModelNumber;
			this.FirmwareRev = FirmwareRev;
            this.InterfaceType = InterfaceType;
            this.MediaType = MediaType;
			this.BufferSize = BufferSize;
			this.Cylinders = Cylinders;
			this.Heads = Heads;
			this.Sectors = Sectors;
            this.SectorsPerTrack = SectorsPerTrack;
            this.BytesPerSector = BytesPerSector;
		}
	}

	/// <summary>
	/// HDiskInfo 的摘要说明。
	/// </summary>
	public class HDiskInfo
	{

        [DllImport("GetDiskSerial")]
        public static extern void SetLicenseKey(string RegCode);
        [DllImport("GetDiskSerial")]
        public static extern string GetDllVer();
        [DllImport("GetDiskSerial")]
        public static extern int GetDriveCount();
        [DllImport("GetDiskSerial")]
        public static extern string GetDriveLetter(int DriveIndex);
        [DllImport("GetDiskSerial")]
        public static extern string GetDriveSize(int DriveIndex);
		[DllImport("GetDiskSerial")]
        public static extern int GetDriveInfo(int DriveIndex, ref DiskInfo DiskInfo);
		[DllImport("GetDiskSerial")]
        public static extern string GetSerialNumber(int DriveIndex);
		[DllImport("GetDiskSerial")]
        public static extern string GetModelNumber(int DriveIndex);
		[DllImport("GetDiskSerial")]
        public static extern string GetFirmwareRev(int DriveIndex);
        [DllImport("GetDiskSerial")]
        public static extern string GetInterfaceType(int DriveIndex);
        [DllImport("GetDiskSerial")]
        public static extern string GetMediaType(int DriveIndex);
		[DllImport("GetDiskSerial")]
        public static extern int GetBufferSize(int DriveIndex);
		[DllImport("GetDiskSerial")]
        public static extern int GetCylinders(int DriveIndex);
		[DllImport("GetDiskSerial")]
        public static extern int GetHeads(int DriveIndex);
		[DllImport("GetDiskSerial")]
        public static extern int GetSectors(int DriveIndex);
        [DllImport("GetDiskSerial")]
        public static extern int GetSectorsPerTrack(int DriveIndex);
        [DllImport("GetDiskSerial")]
        public static extern int GetBytesPerSector(int DriveIndex);
        [DllImport("GetDiskSerial")]
        public static extern string GetDiskVolumeNumber(string DriveLetter);

		public HDiskInfo()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
	}
}
