using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

	public int health = 5;
	public int damage = 5;

	private bool killed = false;
	public bool Killed { get { return killed; } }

	void OnTriggerEnter(Collider otherCollider)
	{
		if (otherCollider.GetComponent<Bullet>() != null)
		{
			Bullet bullet = otherCollider.GetComponent<Bullet>();
			if (bullet.ShotByPlayer == true)
			{
				health -= bullet.damage;
				bullet.gameObject.SetActive(false);

				if (health <= 0)
				{
					if (killed == false)
					{
						killed = true;
						OnKill();
					}
				}
			}
		}
	}

	protected virtual void OnKill()
	{

		//SceneManager.LoadScene("Menu");
	}
}
