using System;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : MonoBehaviour{
	public List<BoardItem> Items;
	[SerializeField] private BoardItem ItemTemplate;
	public EditPlayer EditPlayerPanel;
	public AddPlayer AddPlayerPanel;
	public Transform Content;

	public void SetupShop(Transform Content){
		var item = Instantiate(ItemTemplate, Content);
		item.Setup(this, item);
		if (Content.transform.childCount > 1){
			SortLeaderBoard();
		}
	}

	public void AddPlayerButton(){
		AddPlayerPanel.gameObject.SetActive(true);
	}



	public void SortLeaderBoard(){
		BoardItem temp;
		for (int i = 0; i < Items.Count; i++){
			for (int j = i + 1; j < Items.Count; j++){
				var a = Convert.ToInt32(Items[i].Score.text);
				var b = Convert.ToInt32(Items[j].Score.text);
				if (a < b){
					temp = Items[i];
					Items[i] = Items[j];
					Items[j] = temp;
				}
			}
		}

		for (int i = 0; i < Items.Count; i++){
			Items[i].transform.SetSiblingIndex(i);
			Items[i].PlaceNumber.text = i + 1 + "";
		}
	}
}