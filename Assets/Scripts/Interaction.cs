using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {
	
	//public GameObject _tapButtonObject;
	//Button _tapButton;

	public GameObject _messageObject;
	Text _message;

	public GameObject _egg;

	public GameObject _spy;

	int _taps;

	int _day = 73;//System.DateTime.Now.DayOfYear;
	//int _hour = System.DateTime.Now.Hour;
	
	// Use this for initialization
	void Start () {

		//_tapButton = _tapButtonObject.GetComponent<Button>();
		//_tapButton.onClick.AddListener( tapButtonPressed );

		_message = _messageObject.GetComponent<Text>();
		
		_egg.SetActive(false);
		_spy.SetActive(false);
		_message.text = "";

		//set hatch date
		if ( _day < 72 ){
			_egg.SetActive(true);
		}

		else _spy.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
	}
	public void tapButtonPressed(){

		if ( _day == 69 ){
			if( _taps <= 0 ){
				_message.text = "An egg appeared in your tellie phone...";
			}
			if( _taps == 1 ){
				_message.text = "Are you delighted?";
			}
			if( _taps >= 2 ){
				_message.text = "Not much happened today, but tomorrow..?";
			}
		}
		//WED
		if ( _day == 70 ){
			if( _taps <= 0 ){
				_message.text = "I wonder what happens now - thought Mark.";
			}
			if( _taps == 1 ){
				_message.text = "He tapped again...";
			}
			if( _taps >= 2 ){
				_message.text = "What a tease, not much happened today either.";
			}
		}
		
		//THUR
		if ( _day == 71 ){
			if( _taps <= 0 ){
				_message.text = "What a boring egg... But he couldn't help but to tap again...";
			}
			if( _taps == 1 ){
				_message.text = "He thought about sending 'someone' a hello insetead.";
			}
			if( _taps == 2 ){
				_message.text = "But could not resist tapping again... ";
			}
			if( _taps >= 3 ){
				_message.text = "... a tiny sound was heard.";
			}
		}
		//FRI - hatched
		if ( _day == 72 ){
			if( _taps <= 0 ){
				_message.text = "Wha?!?!? Who are you!!!";
			}
			if( _taps == 1 ){
				_message.text = "Me? I'm Spy - Torri says to tell you that she misses you.";
			}
			if( _taps >= 2 ){
				_message.text = "Wha!?!? That tickles.";
			}
		}
		//SAT
		if ( _day == 73 ){
			if( _taps <= 0 ){
				_message.text = "Are you playing 'Mountain Men' with Bryan today?";
			}
			if( _taps == 1 ){
				_message.text = "Torri says - SWAWESOME - whatever that means.";
			}
			if( _taps >= 2 ){
				_message.text = "Biiiiiicycle..! Biiiiicycle..!";
			}
		}
		//SUN
		if ( _day == 74 ){
			if( _taps <= 0 ){
				_message.text = "O hai Mark.";
			}
			if( _taps == 1 ){
				_message.text = "Sunday? You shoudl chill, and take a nap today.";
			}
			if( _taps >= 2 ){
				_message.text = "Jesus says so.";
			}
		}
		//MON
		if ( _day == 75 ){
			if( _taps <= 0 ){
				_message.text = "Wow! You remembered me?";
			}
			if( _taps == 1 ){
				_message.text = "Wha! That still tickles.";
			}
			if( _taps >= 2 ){
				_message.text = "0u0";
			}
		}
		//TUE
		if ( _day == 76 ){
			if( _taps <= 0 ){
				_message.text = "Mark waited apprehensively.";
			}
			if( _taps == 1 ){
				_message.text = "What happens on a Tuesday...?";
			}
			if( _taps == 2 ){
				_message.text = "WAH! Torri says that she's coming back!";
			}
			if( _taps >= 3 ){
				_message.text = "WAH! Torri says that she's coming back!";
			}
		}
		//Til next year
		if ( _day >= 77 ){
			if( _taps <= 0 ){
				_message.text = "❤";
			}
			if( _taps >= 100 ){
				_message.text = "And that is love";
			}
		}
		_taps ++;
		Debug.Log(_taps);
	}

}