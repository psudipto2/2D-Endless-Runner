using AchivementMVC;
using UnityEngine;
using Common;

namespace StarMVC
{
    public class StarController
    {
        private StarModel starModel;
        private Transform spawnPoint;
        private StarView starView;
        public StarController(StarModel starModel,Transform spawnPoint,GameObject player,GameObject destroyer)
        {
            this.starModel = starModel;
            this.spawnPoint = spawnPoint;
            this.starView = this.starModel.starView;
            this.starView = GameObject.Instantiate<StarView>(this.starModel.starView, spawnPoint.position,spawnPoint.rotation);
            this.starView.spriteRenderer.sprite = this.starModel.image;
            this.starView.score = this.starModel.score;
            this.starView.player = player;
            this.starView.destroyer = destroyer;
            SubcribeEvents();
            this.starView.setController(this);
        }
        private void SubcribeEvents()
        {
            EventService.Instance.collectedStar += UpdateOnStarCollection;
        }

        private void UpdateOnStarCollection()
        {
            starModel.starCollected += 1;
            PlayerPrefs.SetInt("starCollected", starModel.starCollected);
            AchivementService.Instance.GetAchivementController().CheckForStarCollectedAchivement();
        }
    }
}
