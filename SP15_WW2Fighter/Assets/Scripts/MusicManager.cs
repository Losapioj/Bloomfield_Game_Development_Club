using UnityEngine;
using System.Collections.Generic;

public class MusicManager : MonoBehaviour {

	public List<AudioClip> audioClips = new List<AudioClip>();
	private Dictionary<string, AudioClip> _clipDictionary = new Dictionary<string, AudioClip>();
	
	private bool _isFadingIn = false;
	private bool _isFadingOut = false;
//	private;

	//SINGLETON//
	private static MusicManager _instance;
	
	public static MusicManager instance
	{
		get
		{
			if(_instance == null)
			{
				_instance = GameObject.FindObjectsOfType<MusicManager>();
				
				//if persistant
				DontDestroyOnLoad(_instance.gameObject);
			}
			return _instance;
		}
	}
	
	void Awake()
	{
		if(_instance == null)
		{
			_instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			if(this != _instance)
				Destroy(this.gameObject);
		}
		
		foreach (AudioClip a in audioClips)
		{
			_clipDictionary.Add(a.name, a);
		}
	}

	public void Play(string name)
	{
		//play audio requested
		_clipDictionary[name].
	}
}
