using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels  {

	private int _level, _turns, _score;
	public static List<Levels> Data = new List<Levels>();

	public int Level { 
		get {
			return _level;
		}
		set {
			_level = value;
		}
	}

	public int Turns { 
		get {
			return _turns;
		}
		set {
			_turns = value;
		}
	}

	public int Score { 
		get {
			return _score;
		}
		set {
			_score = value;
		}
	}

	public Levels (int level, int turns, int score) {
		_level = level;
		_turns = turns;
		_score = score;
	}

	public static void InitLevels() {
		var lvl = new Levels(1, 5, 5000);
		Data.Add(lvl);
		lvl = new Levels(2, 5, 7500);
		Data.Add(lvl);
	}

}
