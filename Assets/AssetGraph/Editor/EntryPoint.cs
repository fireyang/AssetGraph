﻿using UnityEngine;
using UnityEditor;

using System.Collections;


[InitializeOnLoad]
public class EntryPoint {
	static EntryPoint () {
		Debug.Log("仮のエントリーポイント、適当にGUIを出さなくても動くテスト起動用として機能させる。");
		var a = new AssetGraph.AssetGraph();
		a.InitializeGraph();
		Debug.Log("test done");
	}
	
}
