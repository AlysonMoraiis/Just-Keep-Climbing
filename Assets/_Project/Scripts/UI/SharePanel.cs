using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SharePanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _highscoreText;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _dateTimeText;
    [SerializeField] private GameData _gameData;
    [SerializeField] private GameObject _sharePanel;

    private void OnEnable()
    {
        int tScore = (int)_gameData.LastScore;
        _scoreText.text = tScore.ToString();

        int tHighscore = (int)_gameData.Highscore;
        _highscoreText.text = tHighscore.ToString();

        DateTime dt = DateTime.Now;

        _dateTimeText.text = string.Format("{0}/{1}/{2}", dt.Month, dt.Day, dt.Year);

        StartCoroutine(TakeScreenShotAndShare());
    }

    private IEnumerator TakeScreenShotAndShare()
    {
        yield return new WaitForEndOfFrame();

        Texture2D tx = new Texture2D (Screen.width, Screen.height, TextureFormat.RGB24, false);
        tx.ReadPixels (new Rect(0,0, Screen.width, Screen.height), 0, 0);
        tx.Apply();

        string path = Path.Combine (Application.temporaryCachePath, "shareImage.png");
        File.WriteAllBytes (path,tx.EncodeToPNG());

        Destroy(tx);

        new NativeShare ()
			.AddFile (path)
			.SetSubject ("This is my score")
			.SetText ("share your score with your friends")
			.Share ();

        _sharePanel.SetActive(false);
    }
}
