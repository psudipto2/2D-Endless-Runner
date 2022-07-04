using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarMVC;

namespace StarMVC
{
    public class StarController
    {
        private StarModel starModel;
        private Transform spawnPoint;
        private StarView starView;
        public StarController(StarModel starModel,Transform spawnPoint,GameObject player)
        {
            this.starModel = starModel;
            this.spawnPoint = spawnPoint;
            this.starView = this.starModel.starView;
            Debug.Log(this.starView);
            this.starView = GameObject.Instantiate<StarView>(this.starModel.starView, spawnPoint.position,spawnPoint.rotation);
            this.starView.spriteRenderer.sprite = this.starModel.image;
            this.starView.score = this.starModel.score;
            this.starView.player = player;
            this.starView.setController(this);
        }
    }
}
