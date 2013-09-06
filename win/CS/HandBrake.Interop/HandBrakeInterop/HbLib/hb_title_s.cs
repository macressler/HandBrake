﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="hb_title_s.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Defines the hb_title_s type.
// </summary>
// <auto-generated> Disable Stylecop Warnings for this file  </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.HbLib
{
	using System;
	using System.Runtime.InteropServices;

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct hb_title_s
	{
		/// Anonymous_990d28ea_6cf3_4fbc_8143_4df9513e9550
		public hb_title_type_anon type;

		public uint reg_desc;

		/// char[1024]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string path;

		/// char[1024]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string name;

		/// int
		public int index;

		public int playlist;

		/// int
		public int vts;

		/// int
		public int ttn;

		/// int
		public int cell_start;

		/// int
		public int cell_end;

		/// int
		public ulong block_start;

		/// int
		public ulong block_end;

		/// int
		public ulong block_count;

		/// int
		public int angle_count;

		public IntPtr opaque_priv;

		/// int
		public int hours;

		/// int
		public int minutes;

		/// int
		public int seconds;

		/// uint64_t->unsigned int
		public ulong duration;

		/// double
		public double aspect;

		/// double
		public double container_aspect;

		public int has_resolution_change;

		/// int
		public int width;

		/// int
		public int height;

		/// int
		public int pixel_aspect_width;

		/// int
		public int pixel_aspect_height;

		public int color_prim;
		public int color_transfer; 
		public int color_matrix; 

		/// int
		public int rate;

		/// int
		public int rate_base;

		/// int[4]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
		public int[] crop;

		public hb_title_demuxer_anon demuxer;

		/// int
		public int detected_interlacing;

		public int pcr_pid;

		/// int
		public int video_id;

		/// int
		public int video_codec;

		public uint video_stream_type;

		/// int
		public int video_codec_param;

		/// char*
		[MarshalAs(UnmanagedType.LPStr)]
		public string video_codec_name;

		/// int
		public int video_bitrate;

		/// char*
		[MarshalAs(UnmanagedType.LPStr)]
		public string container_name;

		/// int
		public int data_rate;

        public int qsv_decode_support;

		/// hb_metadata_t*
		public IntPtr metadata;

		/// hb_list_t*
		public IntPtr list_chapter;

		/// hb_list_t*
		public IntPtr list_audio;

		/// hb_list_t*
		public IntPtr list_subtitle;

		/// hb_list_t*
		public IntPtr list_attachment;

		/// hb_job_t*
		public IntPtr job;

		/// uint32_t->unsigned int
		public uint flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct hb_title_set_s
	{
		///hb_list_t   *
		public IntPtr list_title;

		// int
		public int feature;
	}

	public enum hb_title_type_anon
	{
		HB_DVD_TYPE,

		HB_BD_TYPE,

		HB_STREAM_TYPE,

		HB_FF_STREAM_TYPE,
	}

	public enum hb_title_demuxer_anon
	{
		HB_DVD_DEMUXER = 0,

		HB_MPEG_DEMUXER,

		HB_NULL_DEMUXER,
	}
}
