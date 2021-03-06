﻿//*************************************************************************************************
// DEBUT DU FICHIER
//*************************************************************************************************

//*************************************************************************************************
// Nom           : FreeMono9pt.cs
// Auteur        : Nicolas Dagnas
// Description   : Déclaration de l'objet FreeMono9pt
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

	//  #####   ###   #   #  #####
	//  #      #   #  ##  #    #  
	//  ###    #   #  # # #    #  
	//  #      #   #  #  ##    #  
	//  #       ###   #   #    #  

	//*********************************************************************************************
	// Classe FreeMono9pt
	//*********************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------
	/// <summary>
	/// Police Free Mono en 9 Points de hauteur.
	/// </summary>
	//---------------------------------------------------------------------------------------------
	public class FreeMono9pt : DisplayFont
		{
		//*****************************************************************************************
		static uint[] MemoryBitmaps = new uint[] {
			0xAA, 0xA8, 0x0C, 0xED, 0x24, 0x92, 0x48, 0x24, 0x48, 0x91, 0x2F, 0xE4,
			0x89, 0x7F, 0x28, 0x51, 0x22, 0x40, 0x08, 0x3E, 0x62, 0x40, 0x30, 0x0E,
			0x01, 0x81, 0xC3, 0xBE, 0x08, 0x08, 0x71, 0x12, 0x23, 0x80, 0x23, 0xB8,
			0x0E, 0x22, 0x44, 0x70, 0x38, 0x81, 0x02, 0x06, 0x1A, 0x65, 0x46, 0xC8,
			0xEC, 0xE9, 0x24, 0x5A, 0xAA, 0xA9, 0x40, 0xA9, 0x55, 0x5A, 0x80, 0x10,
			0x22, 0x4B, 0xE3, 0x05, 0x11, 0x00, 0x10, 0x20, 0x47, 0xF1, 0x02, 0x04,
			0x00, 0x6B, 0x48, 0xFF, 0x00, 0xF0, 0x02, 0x08, 0x10, 0x60, 0x81, 0x04,
			0x08, 0x20, 0x41, 0x02, 0x08, 0x00, 0x38, 0x8A, 0x0C, 0x18, 0x30, 0x60,
			0xC1, 0x82, 0x88, 0xE0, 0x27, 0x28, 0x42, 0x10, 0x84, 0x21, 0x3E, 0x38,
			0x8A, 0x08, 0x10, 0x20, 0x82, 0x08, 0x61, 0x03, 0xF8, 0x7C, 0x06, 0x02,
			0x02, 0x1C, 0x06, 0x01, 0x01, 0x01, 0x42, 0x3C, 0x18, 0xA2, 0x92, 0x8A,
			0x28, 0xBF, 0x08, 0x21, 0xC0, 0x7C, 0x81, 0x03, 0xE4, 0x40, 0x40, 0x81,
			0x03, 0x88, 0xE0, 0x1E, 0x41, 0x04, 0x0B, 0x98, 0xB0, 0xC1, 0xC2, 0x88,
			0xE0, 0xFE, 0x04, 0x08, 0x20, 0x40, 0x82, 0x04, 0x08, 0x20, 0x40, 0x38,
			0x8A, 0x0C, 0x14, 0x47, 0x11, 0x41, 0x83, 0x8C, 0xE0, 0x38, 0x8A, 0x1C,
			0x18, 0x68, 0xCE, 0x81, 0x04, 0x13, 0xC0, 0xF0, 0x0F, 0x6C, 0x00, 0xD2,
			0xD2, 0x00, 0x03, 0x04, 0x18, 0x60, 0x60, 0x18, 0x04, 0x03, 0xFF, 0x80,
			0x00, 0x1F, 0xF0, 0x40, 0x18, 0x03, 0x00, 0x60, 0x20, 0x60, 0xC0, 0x80,
			0x3D, 0x84, 0x08, 0x30, 0xC2, 0x00, 0x00, 0x00, 0x30, 0x3C, 0x46, 0x82,
			0x8E, 0xB2, 0xA2, 0xA2, 0x9F, 0x80, 0x80, 0x40, 0x3C, 0x3C, 0x01, 0x40,
			0x28, 0x09, 0x01, 0x10, 0x42, 0x0F, 0xC1, 0x04, 0x40, 0x9E, 0x3C, 0xFE,
			0x21, 0x90, 0x48, 0x67, 0xE2, 0x09, 0x02, 0x81, 0x41, 0xFF, 0x80, 0x3E,
			0xB0, 0xF0, 0x30, 0x08, 0x04, 0x02, 0x00, 0x80, 0x60, 0x8F, 0x80, 0xFE,
			0x21, 0x90, 0x68, 0x14, 0x0A, 0x05, 0x02, 0x83, 0x43, 0x7F, 0x00, 0xFF,
			0x20, 0x90, 0x08, 0x87, 0xC2, 0x21, 0x00, 0x81, 0x40, 0xFF, 0xC0, 0xFF,
			0xA0, 0x50, 0x08, 0x87, 0xC2, 0x21, 0x00, 0x80, 0x40, 0x78, 0x00, 0x1E,
			0x98, 0x6C, 0x0A, 0x00, 0x80, 0x20, 0xF8, 0x0B, 0x02, 0x60, 0x87, 0xC0,
			0xE3, 0xA0, 0x90, 0x48, 0x27, 0xF2, 0x09, 0x04, 0x82, 0x41, 0x71, 0xC0,
			0xF9, 0x08, 0x42, 0x10, 0x84, 0x27, 0xC0, 0x1F, 0x02, 0x02, 0x02, 0x02,
			0x02, 0x82, 0x82, 0xC6, 0x78, 0xE3, 0xA1, 0x11, 0x09, 0x05, 0x83, 0x21,
			0x08, 0x84, 0x41, 0x70, 0xC0, 0xE0, 0x40, 0x40, 0x40, 0x40, 0x40, 0x41,
			0x41, 0x41, 0xFF, 0xE0, 0xEC, 0x19, 0x45, 0x28, 0xA4, 0xA4, 0x94, 0x91,
			0x12, 0x02, 0x40, 0x5C, 0x1C, 0xC3, 0xB0, 0x94, 0x4A, 0x24, 0x92, 0x49,
			0x14, 0x8A, 0x43, 0x70, 0x80, 0x1E, 0x31, 0x90, 0x50, 0x18, 0x0C, 0x06,
			0x02, 0x82, 0x63, 0x0F, 0x00, 0xFE, 0x43, 0x41, 0x41, 0x42, 0x7C, 0x40,
			0x40, 0x40, 0xF0, 0x1C, 0x31, 0x90, 0x50, 0x18, 0x0C, 0x06, 0x02, 0x82,
			0x63, 0x1F, 0x04, 0x07, 0x92, 0x30, 0xFE, 0x21, 0x90, 0x48, 0x24, 0x23,
			0xE1, 0x10, 0x84, 0x41, 0x70, 0xC0, 0x3A, 0xCD, 0x0A, 0x03, 0x01, 0x80,
			0xC1, 0xC7, 0x78, 0xFF, 0xC4, 0x62, 0x21, 0x00, 0x80, 0x40, 0x20, 0x10,
			0x08, 0x1F, 0x00, 0xE3, 0xA0, 0x90, 0x48, 0x24, 0x12, 0x09, 0x04, 0x82,
			0x22, 0x0E, 0x00, 0xF1, 0xE8, 0x10, 0x82, 0x10, 0x42, 0x10, 0x22, 0x04,
			0x80, 0x50, 0x0C, 0x00, 0x80, 0xF1, 0xE8, 0x09, 0x11, 0x25, 0x44, 0xA8,
			0x55, 0x0C, 0xA1, 0x8C, 0x31, 0x84, 0x30, 0xE3, 0xA0, 0x88, 0x82, 0x80,
			0x80, 0xC0, 0x90, 0x44, 0x41, 0x71, 0xC0, 0xE3, 0xA0, 0x88, 0x82, 0x81,
			0x40, 0x40, 0x20, 0x10, 0x08, 0x1F, 0x00, 0xFD, 0x0A, 0x20, 0x81, 0x04,
			0x10, 0x21, 0x83, 0xFC, 0xEA, 0xAA, 0xAA, 0xC0, 0x80, 0x81, 0x03, 0x02,
			0x04, 0x04, 0x08, 0x08, 0x10, 0x10, 0x20, 0x20, 0xD5, 0x55, 0x55, 0xC0,
			0x10, 0x51, 0x22, 0x28, 0x20, 0xFF, 0xE0, 0x88, 0x80, 0x7E, 0x00, 0x80,
			0x47, 0xEC, 0x14, 0x0A, 0x0C, 0xFB, 0xC0, 0x20, 0x10, 0x0B, 0xC6, 0x12,
			0x05, 0x02, 0x81, 0x40, 0xB0, 0xB7, 0x80, 0x3A, 0x8E, 0x0C, 0x08, 0x10,
			0x10, 0x9E, 0x03, 0x00, 0x80, 0x47, 0xA4, 0x34, 0x0A, 0x05, 0x02, 0x81,
			0x21, 0x8F, 0x60, 0x3C, 0x43, 0x81, 0xFF, 0x80, 0x80, 0x61, 0x3E, 0x3D,
			0x04, 0x3E, 0x41, 0x04, 0x10, 0x41, 0x0F, 0x80, 0x3D, 0xA1, 0xA0, 0x50,
			0x28, 0x14, 0x09, 0x0C, 0x7A, 0x01, 0x01, 0x87, 0x80, 0xC0, 0x20, 0x10,
			0x0B, 0xC6, 0x32, 0x09, 0x04, 0x82, 0x41, 0x20, 0xB8, 0xE0, 0x10, 0x01,
			0xC0, 0x81, 0x02, 0x04, 0x08, 0x11, 0xFC, 0x10, 0x3E, 0x10, 0x84, 0x21,
			0x08, 0x42, 0x3F, 0x00, 0xC0, 0x40, 0x40, 0x4F, 0x44, 0x58, 0x70, 0x48,
			0x44, 0x42, 0xC7, 0x70, 0x20, 0x40, 0x81, 0x02, 0x04, 0x08, 0x10, 0x23,
			0xF8, 0xB7, 0x64, 0x62, 0x31, 0x18, 0x8C, 0x46, 0x23, 0x91, 0x5E, 0x31,
			0x90, 0x48, 0x24, 0x12, 0x09, 0x05, 0xC7, 0x3E, 0x31, 0xA0, 0x30, 0x18,
			0x0C, 0x05, 0x8C, 0x7C, 0xDE, 0x30, 0x90, 0x28, 0x14, 0x0A, 0x05, 0x84,
			0xBC, 0x40, 0x20, 0x38, 0x00, 0x3D, 0xA1, 0xA0, 0x50, 0x28, 0x14, 0x09,
			0x0C, 0x7A, 0x01, 0x00, 0x80, 0xE0, 0xCE, 0xA1, 0x82, 0x04, 0x08, 0x10,
			0x7C, 0x3A, 0x8D, 0x0B, 0x80, 0xF0, 0x70, 0xDE, 0x40, 0x40, 0xFC, 0x40,
			0x40, 0x40, 0x40, 0x40, 0x41, 0x3E, 0xC3, 0x41, 0x41, 0x41, 0x41, 0x41,
			0x43, 0x3D, 0xE3, 0xA0, 0x90, 0x84, 0x42, 0x20, 0xA0, 0x50, 0x10, 0xE3,
			0xC0, 0x92, 0x4B, 0x25, 0x92, 0xA9, 0x98, 0x44, 0xE3, 0x31, 0x05, 0x01,
			0x01, 0x41, 0x11, 0x05, 0xC7, 0xE3, 0xA0, 0x90, 0x84, 0x42, 0x40, 0xA0,
			0x60, 0x10, 0x10, 0x08, 0x3E, 0x00, 0xFD, 0x08, 0x20, 0x82, 0x08, 0x10,
			0xBF, 0x29, 0x24, 0xA2, 0x49, 0x26, 0xFF, 0xF8, 0x89, 0x24, 0x8A, 0x49,
			0x2C, 0x61, 0x24, 0x30 };
		//*****************************************************************************************

		//*****************************************************************************************
		static DisplayFontGlyph[] MemoryGlyphs = new DisplayFontGlyph[] {
			new DisplayFontGlyph (     0,   0,   0,  11,    0,    1 ),   // 0x20 ' '
			new DisplayFontGlyph (     0,   2,  11,  11,    4,  -10 ),   // 0x21 '!'
			new DisplayFontGlyph (     3,   6,   5,  11,    2,  -10 ),   // 0x22 '"'
			new DisplayFontGlyph (     7,   7,  12,  11,    2,  -10 ),   // 0x23 '#'
			new DisplayFontGlyph (    18,   8,  12,  11,    1,  -10 ),   // 0x24 '$'
			new DisplayFontGlyph (    30,   7,  11,  11,    2,  -10 ),   // 0x25 '%'
			new DisplayFontGlyph (    40,   7,  10,  11,    2,   -9 ),   // 0x26 '&'
			new DisplayFontGlyph (    49,   3,   5,  11,    4,  -10 ),   // 0x27 '''
			new DisplayFontGlyph (    51,   2,  13,  11,    5,  -10 ),   // 0x28 '('
			new DisplayFontGlyph (    55,   2,  13,  11,    4,  -10 ),   // 0x29 ')'
			new DisplayFontGlyph (    59,   7,   7,  11,    2,  -10 ),   // 0x2A '*'
			new DisplayFontGlyph (    66,   7,   7,  11,    2,   -8 ),   // 0x2B '+'
			new DisplayFontGlyph (    73,   3,   5,  11,    2,   -1 ),   // 0x2C ','
			new DisplayFontGlyph (    75,   9,   1,  11,    1,   -5 ),   // 0x2D '-'
			new DisplayFontGlyph (    77,   2,   2,  11,    4,   -1 ),   // 0x2E '.'
			new DisplayFontGlyph (    78,   7,  13,  11,    2,  -11 ),   // 0x2F '/'
			new DisplayFontGlyph (    90,   7,  11,  11,    2,  -10 ),   // 0x30 '0'
			new DisplayFontGlyph (   100,   5,  11,  11,    3,  -10 ),   // 0x31 '1'
			new DisplayFontGlyph (   107,   7,  11,  11,    2,  -10 ),   // 0x32 '2'
			new DisplayFontGlyph (   117,   8,  11,  11,    1,  -10 ),   // 0x33 '3'
			new DisplayFontGlyph (   128,   6,  11,  11,    3,  -10 ),   // 0x34 '4'
			new DisplayFontGlyph (   137,   7,  11,  11,    2,  -10 ),   // 0x35 '5'
			new DisplayFontGlyph (   147,   7,  11,  11,    2,  -10 ),   // 0x36 '6'
			new DisplayFontGlyph (   157,   7,  11,  11,    2,  -10 ),   // 0x37 '7'
			new DisplayFontGlyph (   167,   7,  11,  11,    2,  -10 ),   // 0x38 '8'
			new DisplayFontGlyph (   177,   7,  11,  11,    2,  -10 ),   // 0x39 '9'
			new DisplayFontGlyph (   187,   2,   8,  11,    4,   -7 ),   // 0x3A ':'
			new DisplayFontGlyph (   189,   3,  11,  11,    3,   -7 ),   // 0x3B ';'
			new DisplayFontGlyph (   194,   8,   8,  11,    1,   -8 ),   // 0x3C '<'
			new DisplayFontGlyph (   202,   9,   4,  11,    1,   -6 ),   // 0x3D '='
			new DisplayFontGlyph (   207,   9,   8,  11,    1,   -8 ),   // 0x3E '>'
			new DisplayFontGlyph (   216,   7,  10,  11,    2,   -9 ),   // 0x3F '?'
			new DisplayFontGlyph (   225,   8,  12,  11,    2,  -10 ),   // 0x40 '@'
			new DisplayFontGlyph (   237,  11,  10,  11,    0,   -9 ),   // 0x41 'A'
			new DisplayFontGlyph (   251,   9,  10,  11,    1,   -9 ),   // 0x42 'B'
			new DisplayFontGlyph (   263,   9,  10,  11,    1,   -9 ),   // 0x43 'C'
			new DisplayFontGlyph (   275,   9,  10,  11,    1,   -9 ),   // 0x44 'D'
			new DisplayFontGlyph (   287,   9,  10,  11,    1,   -9 ),   // 0x45 'E'
			new DisplayFontGlyph (   299,   9,  10,  11,    1,   -9 ),   // 0x46 'F'
			new DisplayFontGlyph (   311,  10,  10,  11,    1,   -9 ),   // 0x47 'G'
			new DisplayFontGlyph (   324,   9,  10,  11,    1,   -9 ),   // 0x48 'H'
			new DisplayFontGlyph (   336,   5,  10,  11,    3,   -9 ),   // 0x49 'I'
			new DisplayFontGlyph (   343,   8,  10,  11,    2,   -9 ),   // 0x4A 'J'
			new DisplayFontGlyph (   353,   9,  10,  11,    1,   -9 ),   // 0x4B 'K'
			new DisplayFontGlyph (   365,   8,  10,  11,    2,   -9 ),   // 0x4C 'L'
			new DisplayFontGlyph (   375,  11,  10,  11,    0,   -9 ),   // 0x4D 'M'
			new DisplayFontGlyph (   389,   9,  10,  11,    1,   -9 ),   // 0x4E 'N'
			new DisplayFontGlyph (   401,   9,  10,  11,    1,   -9 ),   // 0x4F 'O'
			new DisplayFontGlyph (   413,   8,  10,  11,    1,   -9 ),   // 0x50 'P'
			new DisplayFontGlyph (   423,   9,  13,  11,    1,   -9 ),   // 0x51 'Q'
			new DisplayFontGlyph (   438,   9,  10,  11,    1,   -9 ),   // 0x52 'R'
			new DisplayFontGlyph (   450,   7,  10,  11,    2,   -9 ),   // 0x53 'S'
			new DisplayFontGlyph (   459,   9,  10,  11,    1,   -9 ),   // 0x54 'T'
			new DisplayFontGlyph (   471,   9,  10,  11,    1,   -9 ),   // 0x55 'U'
			new DisplayFontGlyph (   483,  11,  10,  11,    0,   -9 ),   // 0x56 'V'
			new DisplayFontGlyph (   497,  11,  10,  11,    0,   -9 ),   // 0x57 'W'
			new DisplayFontGlyph (   511,   9,  10,  11,    1,   -9 ),   // 0x58 'X'
			new DisplayFontGlyph (   523,   9,  10,  11,    1,   -9 ),   // 0x59 'Y'
			new DisplayFontGlyph (   535,   7,  10,  11,    2,   -9 ),   // 0x5A 'Z'
			new DisplayFontGlyph (   544,   2,  13,  11,    5,  -10 ),   // 0x5B '['
			new DisplayFontGlyph (   548,   7,  13,  11,    2,  -11 ),   // 0x5C '\'
			new DisplayFontGlyph (   560,   2,  13,  11,    4,  -10 ),   // 0x5D ']'
			new DisplayFontGlyph (   564,   7,   5,  11,    2,  -10 ),   // 0x5E '^'
			new DisplayFontGlyph (   569,  11,   1,  11,    0,    2 ),   // 0x5F '_'
			new DisplayFontGlyph (   571,   3,   3,  11,    3,  -11 ),   // 0x60 '`'
			new DisplayFontGlyph (   573,   9,   8,  11,    1,   -7 ),   // 0x61 'a'
			new DisplayFontGlyph (   582,   9,  11,  11,    1,  -10 ),   // 0x62 'b'
			new DisplayFontGlyph (   595,   7,   8,  11,    2,   -7 ),   // 0x63 'c'
			new DisplayFontGlyph (   602,   9,  11,  11,    1,  -10 ),   // 0x64 'd'
			new DisplayFontGlyph (   615,   8,   8,  11,    1,   -7 ),   // 0x65 'e'
			new DisplayFontGlyph (   623,   6,  11,  11,    3,  -10 ),   // 0x66 'f'
			new DisplayFontGlyph (   632,   9,  11,  11,    1,   -7 ),   // 0x67 'g'
			new DisplayFontGlyph (   645,   9,  11,  11,    1,  -10 ),   // 0x68 'h'
			new DisplayFontGlyph (   658,   7,  10,  11,    2,   -9 ),   // 0x69 'i'
			new DisplayFontGlyph (   667,   5,  13,  11,    3,   -9 ),   // 0x6A 'j'
			new DisplayFontGlyph (   676,   8,  11,  11,    2,  -10 ),   // 0x6B 'k'
			new DisplayFontGlyph (   687,   7,  11,  11,    2,  -10 ),   // 0x6C 'l'
			new DisplayFontGlyph (   697,   9,   8,  11,    1,   -7 ),   // 0x6D 'm'
			new DisplayFontGlyph (   706,   9,   8,  11,    1,   -7 ),   // 0x6E 'n'
			new DisplayFontGlyph (   715,   9,   8,  11,    1,   -7 ),   // 0x6F 'o'
			new DisplayFontGlyph (   724,   9,  11,  11,    1,   -7 ),   // 0x70 'p'
			new DisplayFontGlyph (   737,   9,  11,  11,    1,   -7 ),   // 0x71 'q'
			new DisplayFontGlyph (   750,   7,   8,  11,    3,   -7 ),   // 0x72 'r'
			new DisplayFontGlyph (   757,   7,   8,  11,    2,   -7 ),   // 0x73 's'
			new DisplayFontGlyph (   764,   8,  10,  11,    2,   -9 ),   // 0x74 't'
			new DisplayFontGlyph (   774,   8,   8,  11,    1,   -7 ),   // 0x75 'u'
			new DisplayFontGlyph (   782,   9,   8,  11,    1,   -7 ),   // 0x76 'v'
			new DisplayFontGlyph (   791,   9,   8,  11,    1,   -7 ),   // 0x77 'w'
			new DisplayFontGlyph (   800,   9,   8,  11,    1,   -7 ),   // 0x78 'x'
			new DisplayFontGlyph (   809,   9,  11,  11,    1,   -7 ),   // 0x79 'y'
			new DisplayFontGlyph (   822,   7,   8,  11,    2,   -7 ),   // 0x7A 'z'
			new DisplayFontGlyph (   829,   3,  13,  11,    4,  -10 ),   // 0x7B '{'
			new DisplayFontGlyph (   834,   1,  13,  11,    5,  -10 ),   // 0x7C '|'
			new DisplayFontGlyph (   836,   3,  13,  11,    4,  -10 ),   // 0x7D '}'
			new DisplayFontGlyph (   841,   7,   3,  11,    2,   -6 ) }; // 0x7E '~'
		//*****************************************************************************************

		//*****************************************************************************************
		public FreeMono9pt ()
			{
			//-------------------------------------------------------------------------------------
			base.Bitmaps     = MemoryBitmaps;
			base.First       = 0x20;
			base.Glyphs      = MemoryGlyphs;
			base.EmHeight    = 9;
			base.LineSpacing = 18;
			base.Name        = "Free Mono 9pt";
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
