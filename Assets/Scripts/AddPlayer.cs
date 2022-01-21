using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddPlayer : MonoBehaviour{
	[SerializeField] private LeaderBoard leaderBoard;
	[SerializeField] private Button ConfirmButton;
	public TMP_InputField NameInputField;
	public TMP_InputField ScoreInputField;
	private BoardItem newItem;

	private void Start(){
		ConfirmButton.interactable = false;
		NameInputField.text = "";
		ScoreInputField.text = "";
	}

	private void Update(){
		if (NameInputField.text != "" && NameInputField.text.Length > 3 && ScoreInputField.text != ""){
			ConfirmButton.interactable = true;
		}
		else{
			ConfirmButton.interactable = false;
		}
	}
	public void ConfirmAddPlayer(){
		leaderBoard.SetupShop(leaderBoard.Content);
		ClosePanel();
	}

	public void ClosePanel(){
		gameObject.SetActive(false);
	}
}