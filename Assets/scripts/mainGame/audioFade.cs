using UnityEngine;
using System.Collections;

public class audioFade : MonoBehaviour {
	
	enum Fade {In, Out};
	public float fadeTime = 4.0F;
	public float targetVolume;
	public string howFade = "In";
	
	void Start () {
		if (howFade=="In"){
			StartCoroutine(FadeAudio(fadeTime, Fade.In));
		}
		else if (howFade=="Out"){
			StartCoroutine(FadeAudio(fadeTime, Fade.Out));
		}
	}
	
	IEnumerator FadeAudio (float timer, Fade fadeType) {
		float start = fadeType == Fade.In? 0.0F : targetVolume;
		float end = fadeType == Fade.In? targetVolume : 0.0F;
		float i = 0.0F;
		float step = targetVolume/timer;
		
		while (i <= targetVolume) {
			i += step * Time.deltaTime;
			audio.volume = Mathf.Lerp(start, end, i);
			yield return new WaitForSeconds(step * Time.deltaTime);
		}
	}
	
}

