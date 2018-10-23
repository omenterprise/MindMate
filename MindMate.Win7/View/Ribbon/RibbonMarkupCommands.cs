﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MindMate.View.Ribbon
{
    public enum RibbonMarkupCommands : uint
    {
		HelpButton = 901,		
		ApplicationMenu = 1000,		
		ButtonNew = 1001,		
		ButtonOpen = 1002,		
		ButtonSave = 1003,		
		SaveAs = 1007,		
		SaveAll = 1006,		
		Export = 1010,		
		ExportAsPNG = 1008,		
		ExportAsJPG = 1009,		
		Close = 1005,		
		ButtonExit = 1004,		
		RecentItems = 1020,		
		TabHome = 2000,		
		NewNode = 2010,		
		NewChildNode = 2011,		
		NewLongNode = 2012,		
		NewNodeAbove = 2013,		
		NewNodeBelow = 2014,		
		NewNodeParent = 2015,		
		GrpEdit = 2030,		
		EditText = 2031,		
		EditLong = 2032,		
		DeleteNode = 2033,		
		GrpClipboard = 2050,		
		Paste = 2051,		
		PasteAsText = 2052,		
		Cut = 2053,		
		Copy = 2054,		
		FormatPainter = 2055,		
		GrpFont = 2070,		
		RichFont = 2071,		
		GrpFormat = 2101,		
		BackColor = 2112,		
		ClearFormatting = 2102,		
		GrpIcons = 2080,		
		IconsGallery = 2081,		
		RemoveLastIcon = 2082,		
		RemoveAllIcons = 2083,		
		LaunchIconsDialog = 2084,		
		TabEdit = 3000,		
		GrpSelect = 3010,		
		SelectAll = 3011,		
		SelectSiblings = 3012,		
		SelectAncestors = 3013,		
		SelectChildren = 3014,		
		SelectDescendents = 3015,		
		SelectDescendentsUpto1 = 3016,		
		SelectDescendentsUpto2 = 3017,		
		SelectDescendentsUpto3 = 3018,		
		SelectDescendentsUpto4 = 3019,		
		SelectDescendentsUpto5 = 3020,		
		ExpandOnSelect = 3029,		
		SelectLevel = 3022,		
		SelectLevel1 = 3023,		
		SelectLevel2 = 3024,		
		SelectLevel3 = 3025,		
		SelectLevel4 = 3026,		
		SelectLevel5 = 3027,		
		SelectLevelCurrent = 3028,		
		GrpExpand = 3101,		
		ExpandAll = 3102,		
		CollapseAll = 3103,		
		ToggleCurrent = 3104,		
		ToggleBranch = 3105,		
		ExpandMapToCurrentLevel = 3110,		
		ExpandMapToLevel1 = 3111,		
		ExpandMapToLevel2 = 3112,		
		ExpandMapToLevel3 = 3113,		
		ExpandMapToLevel4 = 3114,		
		ExpandMapToLevel5 = 3115,		
		GrpNavigate = 3201,		
		NavigateToCenter = 3202,		
		NavigateToFirstSibling = 3203,		
		NavigateToLastSibling = 3204,		
		GrpMove = 3301,		
		MoveUp = 3302,		
		MoveDown = 3303,		
		GrpSort = 3400,		
		SortAlphabetic = 3401,		
		SortDueDate = 3402,		
		SortNodeCount = 3405,		
		SortModifiedDate = 3403,		
		SortCreateDate = 3404,		
		SortOrder = 3406,		
		GrpUndo = 3501,		
		Undo = 3502,		
		Redo = 3503,		
		TabInsert = 4000,		
		GrpHyperlink = 4100,		
		Hyperlink = 4101,		
		HyperlinkFile = 4102,		
		HyperlinkFolder = 4103,		
		RemoveHyperlink = 4104,		
		GrpNote = 4200,		
		InsertNote = 4201,		
		GrpImage = 4400,		
		InsertImage = 4401,		
		GrpTask = 4300,		
		AddTask = 4301,		
		AddTaskToday = 4302,		
		AddTaskTomorrow = 4303,		
		AddTaskNextWeek = 4304,		
		AddTaskNextMonth = 4305,		
		AddTaskNextQuarter = 4306,		
		CompleteTask = 4307,		
		RemoveTask = 4308,		
		TabFormat = 5000,		
		GrpNodeFormat = 5100,		
		NodeShape = 5101,		
		ClearShapeFormat = 1502,		
		LineColor = 5103,		
		LinePattern = 5104,		
		LinePatternSolid = 5201,		
		LinePatternDashed = 5202,		
		LinePatternDotted = 5203,		
		LinePatternMixed = 5204,		
		LineThickness = 5105,		
		LineThickness1 = 5301,		
		LineThickness2 = 5302,		
		LineThickness4 = 5303,		
		GrpNodeStyle = 5400,		
		NodeStyleGallery = 5401,		
		CreateNodeStyle = 5402,		
		GrpClearFormat = 5500,		
		TabView = 6000,		
		GrpViewTask = 6100,		
		ViewCalendar = 6001,		
		ViewTaskList = 6002,		
		GrpViewNote = 6200,		
		ViewNote = 6201,		
		TabImage = 9002,		
		RemoveImage = 9101,		
		GrpImageSize = 9200,		
		IncreaseImageSize = 9201,		
		DecreaseImageSize = 9202,		
		GrpImageAlign = 9300,		
		ImageAlignStart = 9301,		
		ImageAlignCenter = 9302,		
		ImageAlignEnd = 9303,		
		GrpImagePosition = 9400,		
		ImagePosAbove = 9401,		
		ImagePosBefore = 9402,		
		ImagePosBelow = 9403,		
		ImagePosAfter = 9404,		
		TabGroupNote = 7000,		
		TabNoteEditor = 7001,		
		GrpNoteFont = 7100,		
		GrpNoteClearFormat = 7200,		
		GrpParagraph = 7300,		
		Bullets = 7301,		
		Numbers = 7302,		
		AlignLeft = 7304,		
		AlignRight = 7305,		
		AlignCenter = 7306,		
		Justify = 7307,		
		Indent = 7308,		
		Outdent = 7309,		
		RTLTextBlock = 7310,		
		LTRTextBlock = 7311,		
		GrpNoteStyles = 7400,		
		NoteHeading1 = 7401,		
		NoteHeading2 = 7402,		
		NoteHeading3 = 7403,		
		NoteNormal = 7404,		
		GrpNoteTable = 7500,		
		NoteInsertTable = 7501,		
		GrpNoteInsertImage = 7700,		
		NoteInsertImage = 7701,		
		GrpNoteEditHtml = 7600,		
		NoteEditHtml = 7601,		
		TabGroupNoteTable = 8000,		
		TabNoteTableLayout = 8100,		
		GrpCustomizeTable = 8200,		
		ModifyTableProperties = 8201,		
		GrpTableDelete = 8300,		
		DeleteRow = 8301,		
		DeleteColumn = 8302,		
		DeleteTable = 8303,		
		GrpTableInsert = 8400,		
		InsertRowAbove = 8401,		
		InsertRowBelow = 8402,		
		InsertColumnLeft = 8403,		
		InsertColumnRight = 8404,		
		GrpTableMove = 8500,		
		MoveRowUp = 8501,		
		MoveRowDown = 8502,		
		MoveColumnLeft = 8503,		
		MoveColumnRight = 8504,		
	}
}
