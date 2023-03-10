using System.Collections.Generic;
using Skill.SkillTree;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Skill.Characteristic
{
    public class UISkillTreeCharacteristic : MonoBehaviour
    {
        private SkillCharacteristic _skillCharacteristic;
        private List<SkillButtonCharacteristic> _skillButtonList;
        [SerializeField] private GameObject skillPoints;

        public void SetCharacteristicSkills(SkillCharacteristic skillCharacteristic)
        {
            Debug.Log("UISkillTreeCharacteristic SetCharacteristicSkills");
            _skillCharacteristic = skillCharacteristic;
            _skillButtonList = new List<SkillButtonCharacteristic>();

            for (var i = 0; i < transform.childCount; i++)
            {
                _skillButtonList.Add(new SkillButtonCharacteristic(transform.GetChild(i), skillCharacteristic,
                    (SkillCharacteristicType)i));
            }

            _skillCharacteristic.OnSkillUnlocked += UpdateVisuals;
            _skillCharacteristic.OnSkillPointsUpdate += SkillPointsUpdate;
            UpdateVisuals(null, null);
        }

        private void SkillPointsUpdate()
        {
            skillPoints.GetComponent<TextMeshProUGUI>().text = _skillCharacteristic.GetSkillPoints().ToString();
        }

        private void UpdateVisuals(object sender, SkillCharacteristic.OnSkillUnlockedEventArgs e)
        {
            for (var i = 0; i < transform.childCount; i++)
            {
                var skillType = (SkillCharacteristicType)i;
                if (_skillCharacteristic.IsSkillUnlocked(skillType))
                    transform.GetChild(i).GetComponent<Image>().color = Color.white;
                else if (_skillCharacteristic.CanUnlockSkill(skillType))
                    transform.GetChild(i).GetComponent<Image>().color = Color.gray;
                else
                    transform.GetChild(i).GetComponent<Image>().color = Color.black;
            }
        }
    }
}