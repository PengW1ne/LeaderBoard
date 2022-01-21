using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoardItem : MonoBehaviour{
	public TextMeshProUGUI PlaceNumber;
	public TextMeshProUGUI PlayerName;
	public TextMeshProUGUI Score;
	[SerializeField]private Button EditButton;
	[SerializeField]private Button DeleteButton;

	[HideInInspector] public LeaderBoard LeaderBoard;


	public void Setup(LeaderBoard leaderBoard, BoardItem item){
		LeaderBoard = leaderBoard;
		PlayerName.text = LeaderBoard.AddPlayerPanel.NameInputField.text;
		Score.text = LeaderBoard.AddPlayerPanel.ScoreInputField.text;
		EditButton.onClick.AddListener(() => item.EditButtonOnClick());
		DeleteButton.onClick.AddListener(() => item.DeleteButtonOnClick());
		LeaderBoard.Items.Add(item);
	}

	public void EditButtonOnClick(){
		if (LeaderBoard.Items.Contains(this)){
			LeaderBoard.EditPlayerPanel.gameObject.SetActive(true);
			LeaderBoard.EditPlayerPanel.SetInformationAboutPlayer(this);
		}
	}
	public void DeleteButtonOnClick(){
		if (LeaderBoard.Items.Contains(this)){
			LeaderBoard.Items.Remove(this);
			Destroy(gameObject);
		}
	}

}