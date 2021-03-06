﻿//*************************************************************************************************
// DEBUT DU FICHIER
//*************************************************************************************************

//*************************************************************************************************
// Nom           : TomThumb.cs
// Auteur        : Nicolas Dagnas
// Description   : Déclaration de l'objet TomThumb
// Environnement : Visual Studio 2015
// Créé le       : 28/08/2017
// Modifié le    : 28/08/2017
//-------------------------------------------------------------------------------------------------
// Inspiré de    : https://github.com/adafruit/Adafruit-GFX-Library
//*************************************************************************************************

//-------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------
using System;
//-------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------

//*************************************************************************************************
// Début du bloc "Windows.Devices.Media.Collection"
//*************************************************************************************************
namespace Windows.Devices.Media.Collection
	{

	//  #####   ###   #   #         #####  #   #  #   #  #   #  ####          #####  ####   #####
	//    #    #   #  ## ##           #    #   #  #   #  ## ##  #   #            #   #   #    #  
	//    #    #   #  # # #  #####    #    #####  #   #  # # #  ####   #####    #    ####     #  
	//    #    #   #  #   #           #    #   #  #   #  #   #  #   #          #     #        #  
	//    #     ###   #   #           #    #   #   ###   #   #  ####           #     #        #  

	//*********************************************************************************************
	// Classe TomThumb
	//*********************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------
	/// <summary>
	/// Police Tom Thumb.
	/// </summary>
	//---------------------------------------------------------------------------------------------
	public class TomThumb : DisplayFont
		{
		//*****************************************************************************************
		static uint[] MemoryBitmaps = new uint[] {
		   0x00,                                /* 0x20 space */
		   0x80, 0x80, 0x80, 0x00, 0x80,        /* 0x21 exclam */
		   0xA0, 0xA0,                          /* 0x22 quotedbl */
		   0xA0, 0xE0, 0xA0, 0xE0, 0xA0,        /* 0x23 numbersign */
		   0x60, 0xC0, 0x60, 0xC0, 0x40,        /* 0x24 dollar */
		   0x80, 0x20, 0x40, 0x80, 0x20,        /* 0x25 percent */
		   0xC0, 0xC0, 0xE0, 0xA0, 0x60,        /* 0x26 ampersand */
		   0x80, 0x80,                          /* 0x27 quotesingle */
		   0x40, 0x80, 0x80, 0x80, 0x40,        /* 0x28 parenleft */
		   0x80, 0x40, 0x40, 0x40, 0x80,        /* 0x29 parenright */
		   0xA0, 0x40, 0xA0,                    /* 0x2A asterisk */
		   0x40, 0xE0, 0x40,                    /* 0x2B plus */
		   0x40, 0x80,                          /* 0x2C comma */
		   0xE0,                                /* 0x2D hyphen */
		   0x80,                                /* 0x2E period */
		   0x20, 0x20, 0x40, 0x80, 0x80,        /* 0x2F slash */
		   0x60, 0xA0, 0xA0, 0xA0, 0xC0,        /* 0x30 zero */
		   0x40, 0xC0, 0x40, 0x40, 0x40,        /* 0x31 one */
		   0xC0, 0x20, 0x40, 0x80, 0xE0,        /* 0x32 two */
		   0xC0, 0x20, 0x40, 0x20, 0xC0,        /* 0x33 three */
		   0xA0, 0xA0, 0xE0, 0x20, 0x20,        /* 0x34 four */
		   0xE0, 0x80, 0xC0, 0x20, 0xC0,        /* 0x35 five */
		   0x60, 0x80, 0xE0, 0xA0, 0xE0,        /* 0x36 six */
		   0xE0, 0x20, 0x40, 0x80, 0x80,        /* 0x37 seven */
		   0xE0, 0xA0, 0xE0, 0xA0, 0xE0,        /* 0x38 eight */
		   0xE0, 0xA0, 0xE0, 0x20, 0xC0,        /* 0x39 nine */
		   0x80, 0x00, 0x80,                    /* 0x3A colon */
		   0x40, 0x00, 0x40, 0x80,              /* 0x3B semicolon */
		   0x20, 0x40, 0x80, 0x40, 0x20,        /* 0x3C less */
		   0xE0, 0x00, 0xE0,                    /* 0x3D equal */
		   0x80, 0x40, 0x20, 0x40, 0x80,        /* 0x3E greater */
		   0xE0, 0x20, 0x40, 0x00, 0x40,        /* 0x3F question */
		   0x40, 0xA0, 0xE0, 0x80, 0x60,        /* 0x40 at */
		   0x40, 0xA0, 0xE0, 0xA0, 0xA0,        /* 0x41 A */
		   0xC0, 0xA0, 0xC0, 0xA0, 0xC0,        /* 0x42 B */
		   0x60, 0x80, 0x80, 0x80, 0x60,        /* 0x43 C */
		   0xC0, 0xA0, 0xA0, 0xA0, 0xC0,        /* 0x44 D */
		   0xE0, 0x80, 0xE0, 0x80, 0xE0,        /* 0x45 E */
		   0xE0, 0x80, 0xE0, 0x80, 0x80,        /* 0x46 F */
		   0x60, 0x80, 0xE0, 0xA0, 0x60,        /* 0x47 G */
		   0xA0, 0xA0, 0xE0, 0xA0, 0xA0,        /* 0x48 H */
		   0xE0, 0x40, 0x40, 0x40, 0xE0,        /* 0x49 I */
		   0x20, 0x20, 0x20, 0xA0, 0x40,        /* 0x4A J */
		   0xA0, 0xA0, 0xC0, 0xA0, 0xA0,        /* 0x4B K */
		   0x80, 0x80, 0x80, 0x80, 0xE0,        /* 0x4C L */
		   0xA0, 0xE0, 0xE0, 0xA0, 0xA0,        /* 0x4D M */
		   0xA0, 0xE0, 0xE0, 0xE0, 0xA0,        /* 0x4E N */
		   0x40, 0xA0, 0xA0, 0xA0, 0x40,        /* 0x4F O */
		   0xC0, 0xA0, 0xC0, 0x80, 0x80,        /* 0x50 P */
		   0x40, 0xA0, 0xA0, 0xE0, 0x60,        /* 0x51 Q */
		   0xC0, 0xA0, 0xE0, 0xC0, 0xA0,        /* 0x52 R */
		   0x60, 0x80, 0x40, 0x20, 0xC0,        /* 0x53 S */
		   0xE0, 0x40, 0x40, 0x40, 0x40,        /* 0x54 T */
		   0xA0, 0xA0, 0xA0, 0xA0, 0x60,        /* 0x55 U */
		   0xA0, 0xA0, 0xA0, 0x40, 0x40,        /* 0x56 V */
		   0xA0, 0xA0, 0xE0, 0xE0, 0xA0,        /* 0x57 W */
		   0xA0, 0xA0, 0x40, 0xA0, 0xA0,        /* 0x58 X */
		   0xA0, 0xA0, 0x40, 0x40, 0x40,        /* 0x59 Y */
		   0xE0, 0x20, 0x40, 0x80, 0xE0,        /* 0x5A Z */
		   0xE0, 0x80, 0x80, 0x80, 0xE0,        /* 0x5B bracketleft */
		   0x80, 0x40, 0x20,                    /* 0x5C backslash */
		   0xE0, 0x20, 0x20, 0x20, 0xE0,        /* 0x5D bracketright */
		   0x40, 0xA0,                          /* 0x5E asciicircum */
		   0xE0,                                /* 0x5F underscore */
		   0x80, 0x40,                          /* 0x60 grave */
		   0xC0, 0x60, 0xA0, 0xE0,              /* 0x61 a */
		   0x80, 0xC0, 0xA0, 0xA0, 0xC0,        /* 0x62 b */
		   0x60, 0x80, 0x80, 0x60,              /* 0x63 c */
		   0x20, 0x60, 0xA0, 0xA0, 0x60,        /* 0x64 d */
		   0x60, 0xA0, 0xC0, 0x60,              /* 0x65 e */
		   0x20, 0x40, 0xE0, 0x40, 0x40,        /* 0x66 f */
		   0x60, 0xA0, 0xE0, 0x20, 0x40,        /* 0x67 g */
		   0x80, 0xC0, 0xA0, 0xA0, 0xA0,        /* 0x68 h */
		   0x80, 0x00, 0x80, 0x80, 0x80,        /* 0x69 i */
		   0x20, 0x00, 0x20, 0x20, 0xA0, 0x40,  /* 0x6A j */
		   0x80, 0xA0, 0xC0, 0xC0, 0xA0,        /* 0x6B k */
		   0xC0, 0x40, 0x40, 0x40, 0xE0,        /* 0x6C l */
		   0xE0, 0xE0, 0xE0, 0xA0,              /* 0x6D m */
		   0xC0, 0xA0, 0xA0, 0xA0,              /* 0x6E n */
		   0x40, 0xA0, 0xA0, 0x40,              /* 0x6F o */
		   0xC0, 0xA0, 0xA0, 0xC0, 0x80,        /* 0x70 p */
		   0x60, 0xA0, 0xA0, 0x60, 0x20,        /* 0x71 q */
		   0x60, 0x80, 0x80, 0x80,              /* 0x72 r */
		   0x60, 0xC0, 0x60, 0xC0,              /* 0x73 s */
		   0x40, 0xE0, 0x40, 0x40, 0x60,        /* 0x74 t */
		   0xA0, 0xA0, 0xA0, 0x60,              /* 0x75 u */
		   0xA0, 0xA0, 0xE0, 0x40,              /* 0x76 v */
		   0xA0, 0xE0, 0xE0, 0xE0,              /* 0x77 w */
		   0xA0, 0x40, 0x40, 0xA0,              /* 0x78 x */
		   0xA0, 0xA0, 0x60, 0x20, 0x40,        /* 0x79 y */
		   0xE0, 0x60, 0xC0, 0xE0,              /* 0x7A z */
		   0x60, 0x40, 0x80, 0x40, 0x60,        /* 0x7B braceleft */
		   0x80, 0x80, 0x00, 0x80, 0x80,        /* 0x7C bar */
		   0xC0, 0x40, 0x20, 0x40, 0xC0,        /* 0x7D braceright */
		   0x60, 0xC0,                          /* 0x7E asciitilde */
		   0x80, 0x00, 0x80, 0x80, 0x80,        /* 0xA1 exclamdown */
		   0x40, 0xE0, 0x80, 0xE0, 0x40,        /* 0xA2 cent */
		   0x60, 0x40, 0xE0, 0x40, 0xE0,        /* 0xA3 sterling */
		   0xA0, 0x40, 0xE0, 0x40, 0xA0,        /* 0xA4 currency */
		   0xA0, 0xA0, 0x40, 0xE0, 0x40,        /* 0xA5 yen */
		   0x80, 0x80, 0x00, 0x80, 0x80,        /* 0xA6 brokenbar */
		   0x60, 0x40, 0xA0, 0x40, 0xC0,        /* 0xA7 section */
		   0xA0,                                /* 0xA8 dieresis */
		   0x60, 0x80, 0x60,                    /* 0xA9 copyright */
		   0x60, 0xA0, 0xE0, 0x00, 0xE0,        /* 0xAA ordfeminine */
		   0x40, 0x80, 0x40,                    /* 0xAB guillemotleft */
		   0xE0, 0x20,                          /* 0xAC logicalnot */
		   0xC0,                                /* 0xAD softhyphen */
		   0xC0, 0xC0, 0xA0,                    /* 0xAE registered */
		   0xE0,                                /* 0xAF macron */
		   0x40, 0xA0, 0x40,                    /* 0xB0 degree */
		   0x40, 0xE0, 0x40, 0x00, 0xE0,        /* 0xB1 plusminus */
		   0xC0, 0x40, 0x60,                    /* 0xB2 twosuperior */
		   0xE0, 0x60, 0xE0,                    /* 0xB3 threesuperior */
		   0x40, 0x80,                          /* 0xB4 acute */
		   0xA0, 0xA0, 0xA0, 0xC0, 0x80,        /* 0xB5 mu */
		   0x60, 0xA0, 0x60, 0x60, 0x60,        /* 0xB6 paragraph */
		   0xE0, 0xE0, 0xE0,                    /* 0xB7 periodcentered */
		   0x40, 0x20, 0xC0,                    /* 0xB8 cedilla */
		   0x80, 0x80, 0x80,                    /* 0xB9 onesuperior */
		   0x40, 0xA0, 0x40, 0x00, 0xE0,        /* 0xBA ordmasculine */
		   0x80, 0x40, 0x80,                    /* 0xBB guillemotright */
		   0x80, 0x80, 0x00, 0x60, 0x20,        /* 0xBC onequarter */
		   0x80, 0x80, 0x00, 0xC0, 0x60,        /* 0xBD onehalf */
		   0xC0, 0xC0, 0x00, 0x60, 0x20,        /* 0xBE threequarters */
		   0x40, 0x00, 0x40, 0x80, 0xE0,        /* 0xBF questiondown */
		   0x40, 0x20, 0x40, 0xE0, 0xA0,        /* 0xC0 Agrave */
		   0x40, 0x80, 0x40, 0xE0, 0xA0,        /* 0xC1 Aacute */
		   0xE0, 0x00, 0x40, 0xE0, 0xA0,        /* 0xC2 Acircumflex */
		   0x60, 0xC0, 0x40, 0xE0, 0xA0,        /* 0xC3 Atilde */
		   0xA0, 0x40, 0xA0, 0xE0, 0xA0,        /* 0xC4 Adieresis */
		   0xC0, 0xC0, 0xA0, 0xE0, 0xA0,        /* 0xC5 Aring */
		   0x60, 0xC0, 0xE0, 0xC0, 0xE0,        /* 0xC6 AE */
		   0x60, 0x80, 0x80, 0x60, 0x20, 0x40,  /* 0xC7 Ccedilla */
		   0x40, 0x20, 0xE0, 0xC0, 0xE0,        /* 0xC8 Egrave */
		   0x40, 0x80, 0xE0, 0xC0, 0xE0,        /* 0xC9 Eacute */
		   0xE0, 0x00, 0xE0, 0xC0, 0xE0,        /* 0xCA Ecircumflex */
		   0xA0, 0x00, 0xE0, 0xC0, 0xE0,        /* 0xCB Edieresis */
		   0x40, 0x20, 0xE0, 0x40, 0xE0,        /* 0xCC Igrave */
		   0x40, 0x80, 0xE0, 0x40, 0xE0,        /* 0xCD Iacute */
		   0xE0, 0x00, 0xE0, 0x40, 0xE0,        /* 0xCE Icircumflex */
		   0xA0, 0x00, 0xE0, 0x40, 0xE0,        /* 0xCF Idieresis */
		   0xC0, 0xA0, 0xE0, 0xA0, 0xC0,        /* 0xD0 Eth */
		   0xC0, 0x60, 0xA0, 0xE0, 0xA0,        /* 0xD1 Ntilde */
		   0x40, 0x20, 0xE0, 0xA0, 0xE0,        /* 0xD2 Ograve */
		   0x40, 0x80, 0xE0, 0xA0, 0xE0,        /* 0xD3 Oacute */
		   0xE0, 0x00, 0xE0, 0xA0, 0xE0,        /* 0xD4 Ocircumflex */
		   0xC0, 0x60, 0xE0, 0xA0, 0xE0,        /* 0xD5 Otilde */
		   0xA0, 0x00, 0xE0, 0xA0, 0xE0,        /* 0xD6 Odieresis */
		   0xA0, 0x40, 0xA0,                    /* 0xD7 multiply */
		   0x60, 0xA0, 0xE0, 0xA0, 0xC0,        /* 0xD8 Oslash */
		   0x80, 0x40, 0xA0, 0xA0, 0xE0,        /* 0xD9 Ugrave */
		   0x20, 0x40, 0xA0, 0xA0, 0xE0,        /* 0xDA Uacute */
		   0xE0, 0x00, 0xA0, 0xA0, 0xE0,        /* 0xDB Ucircumflex */
		   0xA0, 0x00, 0xA0, 0xA0, 0xE0,        /* 0xDC Udieresis */
		   0x20, 0x40, 0xA0, 0xE0, 0x40,        /* 0xDD Yacute */
		   0x80, 0xE0, 0xA0, 0xE0, 0x80,        /* 0xDE Thorn */
		   0x60, 0xA0, 0xC0, 0xA0, 0xC0, 0x80,  /* 0xDF germandbls */
		   0x40, 0x20, 0x60, 0xA0, 0xE0,        /* 0xE0 agrave */
		   0x40, 0x80, 0x60, 0xA0, 0xE0,        /* 0xE1 aacute */
		   0xE0, 0x00, 0x60, 0xA0, 0xE0,        /* 0xE2 acircumflex */
		   0x60, 0xC0, 0x60, 0xA0, 0xE0,        /* 0xE3 atilde */
		   0xA0, 0x00, 0x60, 0xA0, 0xE0,        /* 0xE4 adieresis */
		   0x60, 0x60, 0x60, 0xA0, 0xE0,        /* 0xE5 aring */
		   0x60, 0xE0, 0xE0, 0xC0,              /* 0xE6 ae */
		   0x60, 0x80, 0x60, 0x20, 0x40,        /* 0xE7 ccedilla */
		   0x40, 0x20, 0x60, 0xE0, 0x60,        /* 0xE8 egrave */
		   0x40, 0x80, 0x60, 0xE0, 0x60,        /* 0xE9 eacute */
		   0xE0, 0x00, 0x60, 0xE0, 0x60,        /* 0xEA ecircumflex */
		   0xA0, 0x00, 0x60, 0xE0, 0x60,        /* 0xEB edieresis */
		   0x80, 0x40, 0x80, 0x80, 0x80,        /* 0xEC igrave */
		   0x40, 0x80, 0x40, 0x40, 0x40,        /* 0xED iacute */
		   0xE0, 0x00, 0x40, 0x40, 0x40,        /* 0xEE icircumflex */
		   0xA0, 0x00, 0x40, 0x40, 0x40,        /* 0xEF idieresis */
		   0x60, 0xC0, 0x60, 0xA0, 0x60,        /* 0xF0 eth */
		   0xC0, 0x60, 0xC0, 0xA0, 0xA0,        /* 0xF1 ntilde */
		   0x40, 0x20, 0x40, 0xA0, 0x40,        /* 0xF2 ograve */
		   0x40, 0x80, 0x40, 0xA0, 0x40,        /* 0xF3 oacute */
		   0xE0, 0x00, 0x40, 0xA0, 0x40,        /* 0xF4 ocircumflex */
		   0xC0, 0x60, 0x40, 0xA0, 0x40,        /* 0xF5 otilde */
		   0xA0, 0x00, 0x40, 0xA0, 0x40,        /* 0xF6 odieresis */
		   0x40, 0x00, 0xE0, 0x00, 0x40,        /* 0xF7 divide */
		   0x60, 0xE0, 0xA0, 0xC0,              /* 0xF8 oslash */
		   0x80, 0x40, 0xA0, 0xA0, 0x60,        /* 0xF9 ugrave */
		   0x20, 0x40, 0xA0, 0xA0, 0x60,        /* 0xFA uacute */
		   0xE0, 0x00, 0xA0, 0xA0, 0x60,        /* 0xFB ucircumflex */
		   0xA0, 0x00, 0xA0, 0xA0, 0x60,        /* 0xFC udieresis */
		   0x20, 0x40, 0xA0, 0x60, 0x20, 0x40,  /* 0xFD yacute */
		   0x80, 0xC0, 0xA0, 0xC0, 0x80,        /* 0xFE thorn */
		   0xA0, 0x00, 0xA0, 0x60, 0x20, 0x40,  /* 0xFF ydieresis */
		   0x00,                                /* 0x11D gcircumflex */
		   0x60, 0xC0, 0xE0, 0xC0, 0x60,        /* 0x152 OE */
		   0x60, 0xE0, 0xC0, 0xE0,              /* 0x153 oe */
		   0xA0, 0x60, 0xC0, 0x60, 0xC0,        /* 0x160 Scaron */
		   0xA0, 0x60, 0xC0, 0x60, 0xC0,        /* 0x161 scaron */
		   0xA0, 0x00, 0xA0, 0x40, 0x40,        /* 0x178 Ydieresis */
		   0xA0, 0xE0, 0x60, 0xC0, 0xE0,        /* 0x17D Zcaron */
		   0xA0, 0xE0, 0x60, 0xC0, 0xE0,        /* 0x17E zcaron */
		   0x00,                                /* 0xEA4 uni0EA4 */
		   0x00,                                /* 0x13A0 uni13A0 */
		   0x80,                                /* 0x2022 bullet */
		   0xA0,                                /* 0x2026 ellipsis */
		   0x60, 0xE0, 0xE0, 0xC0, 0x60,        /* 0x20AC Euro */
		   0xE0, 0xA0, 0xA0, 0xA0, 0xE0 };      /* 0xFFFD uniFFFD */
		//*****************************************************************************************

		//*****************************************************************************************
		static DisplayFontGlyph[] MemoryGlyphs = new DisplayFontGlyph[] {
			new DisplayFontGlyph (   0, 8, 1, 2, 0, -5 ),  // 0x20 space
			new DisplayFontGlyph (   1, 8, 5, 2, 0, -5 ),  // 0x21 exclam
			new DisplayFontGlyph (   6, 8, 2, 4, 0, -5 ),  // 0x22 quotedbl
			new DisplayFontGlyph (   8, 8, 5, 4, 0, -5 ),  // 0x23 numbersign
			new DisplayFontGlyph (  13, 8, 5, 4, 0, -5 ),  // 0x24 dollar
			new DisplayFontGlyph (  18, 8, 5, 4, 0, -5 ),  // 0x25 percent
			new DisplayFontGlyph (  23, 8, 5, 4, 0, -5 ),  // 0x26 ampersand
			new DisplayFontGlyph (  28, 8, 2, 2, 0, -5 ),  // 0x27 quotesingle
			new DisplayFontGlyph (  30, 8, 5, 3, 0, -5 ),  // 0x28 parenleft
			new DisplayFontGlyph (  35, 8, 5, 3, 0, -5 ),  // 0x29 parenright
			new DisplayFontGlyph (  40, 8, 3, 4, 0, -5 ),  // 0x2A asterisk
			new DisplayFontGlyph (  43, 8, 3, 4, 0, -4 ),  // 0x2B plus
			new DisplayFontGlyph (  46, 8, 2, 3, 0, -2 ),  // 0x2C comma
			new DisplayFontGlyph (  48, 8, 1, 4, 0, -3 ),  // 0x2D hyphen
			new DisplayFontGlyph (  49, 8, 1, 2, 0, -1 ),  // 0x2E period
			new DisplayFontGlyph (  50, 8, 5, 4, 0, -5 ),  // 0x2F slash
			new DisplayFontGlyph (  55, 8, 5, 4, 0, -5 ),  // 0x30 zero
			new DisplayFontGlyph (  60, 8, 5, 3, 0, -5 ),  // 0x31 one
			new DisplayFontGlyph (  65, 8, 5, 4, 0, -5 ),  // 0x32 two
			new DisplayFontGlyph (  70, 8, 5, 4, 0, -5 ),  // 0x33 three
			new DisplayFontGlyph (  75, 8, 5, 4, 0, -5 ),  // 0x34 four
			new DisplayFontGlyph (  80, 8, 5, 4, 0, -5 ),  // 0x35 five
			new DisplayFontGlyph (  85, 8, 5, 4, 0, -5 ),  // 0x36 six
			new DisplayFontGlyph (  90, 8, 5, 4, 0, -5 ),  // 0x37 seven
			new DisplayFontGlyph (  95, 8, 5, 4, 0, -5 ),  // 0x38 eight
			new DisplayFontGlyph ( 100, 8, 5, 4, 0, -5 ),  // 0x39 nine
			new DisplayFontGlyph ( 105, 8, 3, 2, 0, -4 ),  // 0x3A colon
			new DisplayFontGlyph ( 108, 8, 4, 3, 0, -4 ),  // 0x3B semicolon
			new DisplayFontGlyph ( 112, 8, 5, 4, 0, -5 ),  // 0x3C less
			new DisplayFontGlyph ( 117, 8, 3, 4, 0, -4 ),  // 0x3D equal
			new DisplayFontGlyph ( 120, 8, 5, 4, 0, -5 ),  // 0x3E greater
			new DisplayFontGlyph ( 125, 8, 5, 4, 0, -5 ),  // 0x3F question
			new DisplayFontGlyph ( 130, 8, 5, 4, 0, -5 ),  // 0x40 at
			new DisplayFontGlyph ( 135, 8, 5, 4, 0, -5 ),  // 0x41 A
			new DisplayFontGlyph ( 140, 8, 5, 4, 0, -5 ),  // 0x42 B
			new DisplayFontGlyph ( 145, 8, 5, 4, 0, -5 ),  // 0x43 C
			new DisplayFontGlyph ( 150, 8, 5, 4, 0, -5 ),  // 0x44 D
			new DisplayFontGlyph ( 155, 8, 5, 4, 0, -5 ),  // 0x45 E
			new DisplayFontGlyph ( 160, 8, 5, 4, 0, -5 ),  // 0x46 F
			new DisplayFontGlyph ( 165, 8, 5, 4, 0, -5 ),  // 0x47 G
			new DisplayFontGlyph ( 170, 8, 5, 4, 0, -5 ),  // 0x48 H
			new DisplayFontGlyph ( 175, 8, 5, 4, 0, -5 ),  // 0x49 I
			new DisplayFontGlyph ( 180, 8, 5, 4, 0, -5 ),  // 0x4A J
			new DisplayFontGlyph ( 185, 8, 5, 4, 0, -5 ),  // 0x4B K
			new DisplayFontGlyph ( 190, 8, 5, 4, 0, -5 ),  // 0x4C L
			new DisplayFontGlyph ( 195, 8, 5, 4, 0, -5 ),  // 0x4D M
			new DisplayFontGlyph ( 200, 8, 5, 4, 0, -5 ),  // 0x4E N
			new DisplayFontGlyph ( 205, 8, 5, 4, 0, -5 ),  // 0x4F O
			new DisplayFontGlyph ( 210, 8, 5, 4, 0, -5 ),  // 0x50 P
			new DisplayFontGlyph ( 215, 8, 5, 4, 0, -5 ),  // 0x51 Q
			new DisplayFontGlyph ( 220, 8, 5, 4, 0, -5 ),  // 0x52 R
			new DisplayFontGlyph ( 225, 8, 5, 4, 0, -5 ),  // 0x53 S
			new DisplayFontGlyph ( 230, 8, 5, 4, 0, -5 ),  // 0x54 T
			new DisplayFontGlyph ( 235, 8, 5, 4, 0, -5 ),  // 0x55 U
			new DisplayFontGlyph ( 240, 8, 5, 4, 0, -5 ),  // 0x56 V
			new DisplayFontGlyph ( 245, 8, 5, 4, 0, -5 ),  // 0x57 W
			new DisplayFontGlyph ( 250, 8, 5, 4, 0, -5 ),  // 0x58 X
			new DisplayFontGlyph ( 255, 8, 5, 4, 0, -5 ),  // 0x59 Y
			new DisplayFontGlyph ( 260, 8, 5, 4, 0, -5 ),  // 0x5A Z
			new DisplayFontGlyph ( 265, 8, 5, 4, 0, -5 ),  // 0x5B bracketleft
			new DisplayFontGlyph ( 270, 8, 3, 4, 0, -4 ),  // 0x5C backslash
			new DisplayFontGlyph ( 273, 8, 5, 4, 0, -5 ),  // 0x5D bracketright
			new DisplayFontGlyph ( 278, 8, 2, 4, 0, -5 ),  // 0x5E asciicircum
			new DisplayFontGlyph ( 280, 8, 1, 4, 0, -1 ),  // 0x5F underscore
			new DisplayFontGlyph ( 281, 8, 2, 3, 0, -5 ),  // 0x60 grave
			new DisplayFontGlyph ( 283, 8, 4, 4, 0, -4 ),  // 0x61 a
			new DisplayFontGlyph ( 287, 8, 5, 4, 0, -5 ),  // 0x62 b
			new DisplayFontGlyph ( 292, 8, 4, 4, 0, -4 ),  // 0x63 c
			new DisplayFontGlyph ( 296, 8, 5, 4, 0, -5 ),  // 0x64 d
			new DisplayFontGlyph ( 301, 8, 4, 4, 0, -4 ),  // 0x65 e
			new DisplayFontGlyph ( 305, 8, 5, 4, 0, -5 ),  // 0x66 f
			new DisplayFontGlyph ( 310, 8, 5, 4, 0, -4 ),  // 0x67 g
			new DisplayFontGlyph ( 315, 8, 5, 4, 0, -5 ),  // 0x68 h
			new DisplayFontGlyph ( 320, 8, 5, 2, 0, -5 ),  // 0x69 i
			new DisplayFontGlyph ( 325, 8, 6, 4, 0, -5 ),  // 0x6A j
			new DisplayFontGlyph ( 331, 8, 5, 4, 0, -5 ),  // 0x6B k
			new DisplayFontGlyph ( 336, 8, 5, 4, 0, -5 ),  // 0x6C l
			new DisplayFontGlyph ( 341, 8, 4, 4, 0, -4 ),  // 0x6D m
			new DisplayFontGlyph ( 345, 8, 4, 4, 0, -4 ),  // 0x6E n
			new DisplayFontGlyph ( 349, 8, 4, 4, 0, -4 ),  // 0x6F o
			new DisplayFontGlyph ( 353, 8, 5, 4, 0, -4 ),  // 0x70 p
			new DisplayFontGlyph ( 358, 8, 5, 4, 0, -4 ),  // 0x71 q
			new DisplayFontGlyph ( 363, 8, 4, 4, 0, -4 ),  // 0x72 r
			new DisplayFontGlyph ( 367, 8, 4, 4, 0, -4 ),  // 0x73 s
			new DisplayFontGlyph ( 371, 8, 5, 4, 0, -5 ),  // 0x74 t
			new DisplayFontGlyph ( 376, 8, 4, 4, 0, -4 ),  // 0x75 u
			new DisplayFontGlyph ( 380, 8, 4, 4, 0, -4 ),  // 0x76 v
			new DisplayFontGlyph ( 384, 8, 4, 4, 0, -4 ),  // 0x77 w
			new DisplayFontGlyph ( 388, 8, 4, 4, 0, -4 ),  // 0x78 x
			new DisplayFontGlyph ( 392, 8, 5, 4, 0, -4 ),  // 0x79 y
			new DisplayFontGlyph ( 397, 8, 4, 4, 0, -4 ),  // 0x7A z
			new DisplayFontGlyph ( 401, 8, 5, 4, 0, -5 ),  // 0x7B braceleft
			new DisplayFontGlyph ( 406, 8, 5, 2, 0, -5 ),  // 0x7C bar
			new DisplayFontGlyph ( 411, 8, 5, 4, 0, -5 ),  // 0x7D braceright
			new DisplayFontGlyph ( 416, 8, 2, 4, 0, -5 ),  // 0x7E asciitilde
			new DisplayFontGlyph ( 418, 8, 5, 2, 0, -5 ),  // 0xA1 exclamdown
			new DisplayFontGlyph ( 423, 8, 5, 4, 0, -5 ),  // 0xA2 cent
			new DisplayFontGlyph ( 428, 8, 5, 4, 0, -5 ),  // 0xA3 sterling
			new DisplayFontGlyph ( 433, 8, 5, 4, 0, -5 ),  // 0xA4 currency
			new DisplayFontGlyph ( 438, 8, 5, 4, 0, -5 ),  // 0xA5 yen
			new DisplayFontGlyph ( 443, 8, 5, 2, 0, -5 ),  // 0xA6 brokenbar
			new DisplayFontGlyph ( 448, 8, 5, 4, 0, -5 ),  // 0xA7 section
			new DisplayFontGlyph ( 453, 8, 1, 4, 0, -5 ),  // 0xA8 dieresis
			new DisplayFontGlyph ( 454, 8, 3, 4, 0, -5 ),  // 0xA9 copyright
			new DisplayFontGlyph ( 457, 8, 5, 4, 0, -5 ),  // 0xAA ordfeminine
			new DisplayFontGlyph ( 462, 8, 3, 3, 0, -5 ),  // 0xAB guillemotleft
			new DisplayFontGlyph ( 465, 8, 2, 4, 0, -4 ),  // 0xAC logicalnot
			new DisplayFontGlyph ( 467, 8, 1, 3, 0, -3 ),  // 0xAD softhyphen
			new DisplayFontGlyph ( 468, 8, 3, 4, 0, -5 ),  // 0xAE registered
			new DisplayFontGlyph ( 471, 8, 1, 4, 0, -5 ),  // 0xAF macron
			new DisplayFontGlyph ( 472, 8, 3, 4, 0, -5 ),  // 0xB0 degree
			new DisplayFontGlyph ( 475, 8, 5, 4, 0, -5 ),  // 0xB1 plusminus
			new DisplayFontGlyph ( 480, 8, 3, 4, 0, -5 ),  // 0xB2 twosuperior
			new DisplayFontGlyph ( 483, 8, 3, 4, 0, -5 ),  // 0xB3 threesuperior
			new DisplayFontGlyph ( 486, 8, 2, 3, 0, -5 ),  // 0xB4 acute
			new DisplayFontGlyph ( 488, 8, 5, 4, 0, -5 ),  // 0xB5 mu
			new DisplayFontGlyph ( 493, 8, 5, 4, 0, -5 ),  // 0xB6 paragraph
			new DisplayFontGlyph ( 498, 8, 3, 4, 0, -4 ),  // 0xB7 periodcentered
			new DisplayFontGlyph ( 501, 8, 3, 4, 0, -3 ),  // 0xB8 cedilla
			new DisplayFontGlyph ( 504, 8, 3, 2, 0, -5 ),  // 0xB9 onesuperior
			new DisplayFontGlyph ( 507, 8, 5, 4, 0, -5 ),  // 0xBA ordmasculine
			new DisplayFontGlyph ( 512, 8, 3, 3, 0, -5 ),  // 0xBB guillemotright
			new DisplayFontGlyph ( 515, 8, 5, 4, 0, -5 ),  // 0xBC onequarter
			new DisplayFontGlyph ( 520, 8, 5, 4, 0, -5 ),  // 0xBD onehalf
			new DisplayFontGlyph ( 525, 8, 5, 4, 0, -5 ),  // 0xBE threequarters
			new DisplayFontGlyph ( 530, 8, 5, 4, 0, -5 ),  // 0xBF questiondown
			new DisplayFontGlyph ( 535, 8, 5, 4, 0, -5 ),  // 0xC0 Agrave
			new DisplayFontGlyph ( 540, 8, 5, 4, 0, -5 ),  // 0xC1 Aacute
			new DisplayFontGlyph ( 545, 8, 5, 4, 0, -5 ),  // 0xC2 Acircumflex
			new DisplayFontGlyph ( 550, 8, 5, 4, 0, -5 ),  // 0xC3 Atilde
			new DisplayFontGlyph ( 555, 8, 5, 4, 0, -5 ),  // 0xC4 Adieresis
			new DisplayFontGlyph ( 560, 8, 5, 4, 0, -5 ),  // 0xC5 Aring
			new DisplayFontGlyph ( 565, 8, 5, 4, 0, -5 ),  // 0xC6 AE
			new DisplayFontGlyph ( 570, 8, 6, 4, 0, -5 ),  // 0xC7 Ccedilla
			new DisplayFontGlyph ( 576, 8, 5, 4, 0, -5 ),  // 0xC8 Egrave
			new DisplayFontGlyph ( 581, 8, 5, 4, 0, -5 ),  // 0xC9 Eacute
			new DisplayFontGlyph ( 586, 8, 5, 4, 0, -5 ),  // 0xCA Ecircumflex
			new DisplayFontGlyph ( 591, 8, 5, 4, 0, -5 ),  // 0xCB Edieresis
			new DisplayFontGlyph ( 596, 8, 5, 4, 0, -5 ),  // 0xCC Igrave
			new DisplayFontGlyph ( 601, 8, 5, 4, 0, -5 ),  // 0xCD Iacute
			new DisplayFontGlyph ( 606, 8, 5, 4, 0, -5 ),  // 0xCE Icircumflex
			new DisplayFontGlyph ( 611, 8, 5, 4, 0, -5 ),  // 0xCF Idieresis
			new DisplayFontGlyph ( 616, 8, 5, 4, 0, -5 ),  // 0xD0 Eth
			new DisplayFontGlyph ( 621, 8, 5, 4, 0, -5 ),  // 0xD1 Ntilde
			new DisplayFontGlyph ( 626, 8, 5, 4, 0, -5 ),  // 0xD2 Ograve
			new DisplayFontGlyph ( 631, 8, 5, 4, 0, -5 ),  // 0xD3 Oacute
			new DisplayFontGlyph ( 636, 8, 5, 4, 0, -5 ),  // 0xD4 Ocircumflex
			new DisplayFontGlyph ( 641, 8, 5, 4, 0, -5 ),  // 0xD5 Otilde
			new DisplayFontGlyph ( 646, 8, 5, 4, 0, -5 ),  // 0xD6 Odieresis
			new DisplayFontGlyph ( 651, 8, 3, 4, 0, -4 ),  // 0xD7 multiply
			new DisplayFontGlyph ( 654, 8, 5, 4, 0, -5 ),  // 0xD8 Oslash
			new DisplayFontGlyph ( 659, 8, 5, 4, 0, -5 ),  // 0xD9 Ugrave
			new DisplayFontGlyph ( 664, 8, 5, 4, 0, -5 ),  // 0xDA Uacute
			new DisplayFontGlyph ( 669, 8, 5, 4, 0, -5 ),  // 0xDB Ucircumflex
			new DisplayFontGlyph ( 674, 8, 5, 4, 0, -5 ),  // 0xDC Udieresis
			new DisplayFontGlyph ( 679, 8, 5, 4, 0, -5 ),  // 0xDD Yacute
			new DisplayFontGlyph ( 684, 8, 5, 4, 0, -5 ),  // 0xDE Thorn
			new DisplayFontGlyph ( 689, 8, 6, 4, 0, -5 ),  // 0xDF germandbls
			new DisplayFontGlyph ( 695, 8, 5, 4, 0, -5 ),  // 0xE0 agrave
			new DisplayFontGlyph ( 700, 8, 5, 4, 0, -5 ),  // 0xE1 aacute
			new DisplayFontGlyph ( 705, 8, 5, 4, 0, -5 ),  // 0xE2 acircumflex
			new DisplayFontGlyph ( 710, 8, 5, 4, 0, -5 ),  // 0xE3 atilde
			new DisplayFontGlyph ( 715, 8, 5, 4, 0, -5 ),  // 0xE4 adieresis
			new DisplayFontGlyph ( 720, 8, 5, 4, 0, -5 ),  // 0xE5 aring
			new DisplayFontGlyph ( 725, 8, 4, 4, 0, -4 ),  // 0xE6 ae
			new DisplayFontGlyph ( 729, 8, 5, 4, 0, -4 ),  // 0xE7 ccedilla
			new DisplayFontGlyph ( 734, 8, 5, 4, 0, -5 ),  // 0xE8 egrave
			new DisplayFontGlyph ( 739, 8, 5, 4, 0, -5 ),  // 0xE9 eacute
			new DisplayFontGlyph ( 744, 8, 5, 4, 0, -5 ),  // 0xEA ecircumflex
			new DisplayFontGlyph ( 749, 8, 5, 4, 0, -5 ),  // 0xEB edieresis
			new DisplayFontGlyph ( 754, 8, 5, 3, 0, -5 ),  // 0xEC igrave
			new DisplayFontGlyph ( 759, 8, 5, 3, 0, -5 ),  // 0xED iacute
			new DisplayFontGlyph ( 764, 8, 5, 4, 0, -5 ),  // 0xEE icircumflex
			new DisplayFontGlyph ( 769, 8, 5, 4, 0, -5 ),  // 0xEF idieresis
			new DisplayFontGlyph ( 774, 8, 5, 4, 0, -5 ),  // 0xF0 eth
			new DisplayFontGlyph ( 779, 8, 5, 4, 0, -5 ),  // 0xF1 ntilde
			new DisplayFontGlyph ( 784, 8, 5, 4, 0, -5 ),  // 0xF2 ograve
			new DisplayFontGlyph ( 789, 8, 5, 4, 0, -5 ),  // 0xF3 oacute
			new DisplayFontGlyph ( 794, 8, 5, 4, 0, -5 ),  // 0xF4 ocircumflex
			new DisplayFontGlyph ( 799, 8, 5, 4, 0, -5 ),  // 0xF5 otilde
			new DisplayFontGlyph ( 804, 8, 5, 4, 0, -5 ),  // 0xF6 odieresis
			new DisplayFontGlyph ( 809, 8, 5, 4, 0, -5 ),  // 0xF7 divide
			new DisplayFontGlyph ( 814, 8, 4, 4, 0, -4 ),  // 0xF8 oslash
			new DisplayFontGlyph ( 818, 8, 5, 4, 0, -5 ),  // 0xF9 ugrave
			new DisplayFontGlyph ( 823, 8, 5, 4, 0, -5 ),  // 0xFA uacute
			new DisplayFontGlyph ( 828, 8, 5, 4, 0, -5 ),  // 0xFB ucircumflex
			new DisplayFontGlyph ( 833, 8, 5, 4, 0, -5 ),  // 0xFC udieresis
			new DisplayFontGlyph ( 838, 8, 6, 4, 0, -5 ),  // 0xFD yacute
			new DisplayFontGlyph ( 844, 8, 5, 4, 0, -4 ),  // 0xFE thorn
			new DisplayFontGlyph ( 849, 8, 6, 4, 0, -5 ),  // 0xFF ydieresis
			new DisplayFontGlyph ( 855, 8, 1, 2, 0, -1 ),  // 0x11D gcircumflex
			new DisplayFontGlyph ( 856, 8, 5, 4, 0, -5 ),  // 0x152 OE
			new DisplayFontGlyph ( 861, 8, 4, 4, 0, -4 ),  // 0x153 oe
			new DisplayFontGlyph ( 865, 8, 5, 4, 0, -5 ),  // 0x160 Scaron
			new DisplayFontGlyph ( 870, 8, 5, 4, 0, -5 ),  // 0x161 scaron
			new DisplayFontGlyph ( 875, 8, 5, 4, 0, -5 ),  // 0x178 Ydieresis
			new DisplayFontGlyph ( 880, 8, 5, 4, 0, -5 ),  // 0x17D Zcaron
			new DisplayFontGlyph ( 885, 8, 5, 4, 0, -5 ),  // 0x17E zcaron
			new DisplayFontGlyph ( 890, 8, 1, 2, 0, -1 ),  // 0xEA4 uni0EA4
			new DisplayFontGlyph ( 891, 8, 1, 2, 0, -1 ),  // 0x13A0 uni13A0
			new DisplayFontGlyph ( 892, 8, 1, 2, 0, -3 ),  // 0x2022 bullet
			new DisplayFontGlyph ( 893, 8, 1, 4, 0, -1 ),  // 0x2026 ellipsis
			new DisplayFontGlyph ( 894, 8, 5, 4, 0, -5 ),  // 0x20AC Euro
			new DisplayFontGlyph ( 899, 8, 5, 4, 0, -5 ) };// 0xFFFD uniFFFD
		//*****************************************************************************************

		//*****************************************************************************************
		public TomThumb ()
			{
			//-------------------------------------------------------------------------------------
			base.Bitmaps     = MemoryBitmaps;
			base.First       = 0x20;
			base.Glyphs      = MemoryGlyphs;
			base.EmHeight    = 5;
			base.LineSpacing = 6;
			base.Name        = "Tom Thumb 5pt";
			base.Type        = DisplayFontType.Graphic;
			//-------------------------------------------------------------------------------------
			}
		//*****************************************************************************************
		}
	//---------------------------------------------------------------------------------------------
	#endregion
	//*********************************************************************************************

	} // Fin du namespace "Windows.Devices.Media.Collection"
//*************************************************************************************************

//*************************************************************************************************
// FIN DU FICHIER
//*************************************************************************************************
