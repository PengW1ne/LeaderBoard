using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EditPlayer : MonoBehaviour{
	[SerializeField] private LeaderBoard LeaderBoard;
	[SerializeField] private TMP_InputField NameInputField;
	[SerializeField] private TMP_InputField ScoreInputField;
	[HideInInspector] public BoardItem Item;
	[SerializeField] private Button ConfirmButton;


	public void SetInformationAboutPlayer(BoardItem item){
		Item = item;
		NameInputField.text = item.PlayerName.text;
		ScoreInputField.text = item.Score.text;
	}

	private void Update(){
		if (NameInputField.text != "" && NameInputField.text.Length > 3 && ScoreInputField.text != ""){
			ConfirmButton.interactable = true;
		}
		else{
			ConfirmButton.interactable = false;
		}
	}
	public void ConfirmEditPlayer(){
		Item.PlayerName.text = NameInputField.text;
		Item.Score.text = ScoreInputField.text;
		if (LeaderBoard.Content.transform.childCount > 1){
			LeaderBoard.SortLeaderBoard();
		}
		ClosePanel();
	}

	public void ClosePanel(){
		gameObject.SetActive(false);
	}
}