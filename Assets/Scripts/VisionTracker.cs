using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;

// VisionTracker will record how often a player is looking at this GameObject, and how much of a focus it has had recently.

// Attach VisionTracker to any GameObject if you ever want to get information about whether the player has been looking at it a lot.
// See the "vision test" scenes for a demo.

public class VisionTracker : MonoBehaviour
{
	//How often (in seconds) VisionTracker will check what is looking at what.
	public static float interval = 0.5f;

	//totalLookAtScore will only increment when the lookAtScore is at least this much.
	public float lookAtThreshold = 0.8f;

	//how many seconds of history VisionTracker will record.
	//public float lookAtHistorySeconds = 60;

	//If the main camera is farther than this distance, then LookAtScore will return -1.
	//Set to zero for no maximum distance.
	public float maximumDistance = 5;
	private float maximumDistanceSquared;

	private float totalLookAtScore = 0;
	private GameObject player;
	private float[] lookAtHistory;
	private int historyIndex = 0;
	private WaitForSeconds waitForSeconds;
	public int count = 0;
	public bool enableCount = false;
    private float averageScore = 0;
    private int averageCounter = 0;
    private float sumScore = 0;
	


	void Start()
	{
		waitForSeconds = new WaitForSeconds(interval);
		maximumDistanceSquared = maximumDistance * maximumDistance;
		player = Camera.main.gameObject;
		//lookAtHistory = new float[Mathf.CeilToInt(lookAtHistorySeconds / interval)];
		StartCoroutine(Cycle());
	}

	public float GetHistoryScore()
	{
        //returns a number between [-1,1] where 1 means the player has been directly looking at this object for lookAtHistorySeconds seconds.
        // 0.6 means the player has been somewhat looking at it in these past lookAtHistorySeconds seconds.
        //float total = 0;
        //foreach (float i in lookAtHistory)
        //    total += i;
        //return total / lookAtHistory.Length;
        return averageScore;
    }

	public float GetLookAtScore()
	{
		//returns a score between [-1,1] where 1 means the player is looking directly at this object right now, -1 means directly looking away.
		Vector3 playerToObject = gameObject.transform.position - player.transform.position;

		//if (maximumDistance != 0 && playerToObject.sqrMagnitude > maximumDistanceSquared)
		//return -1;
		float magnitude = playerToObject.magnitude;
		playerToObject.Normalize();
		Vector3 lookDirection = Camera.main.transform.forward;

		//return ((Vector3.Dot(playerToObject, lookDirection)));
		//return ((-(Mathf.Atan(10*(magnitude-maximumDistance))/Mathf.PI) + (Mathf.Atan(1000000000) / Mathf.PI)));
		return ((Vector3.Dot(playerToObject, lookDirection)))*((-(Mathf.Atan(3 * (magnitude - maximumDistance)) / Mathf.PI) + (Mathf.Atan(1000000000) / Mathf.PI)));
	}

	public float GetTotalLookAtScore()
	{
		//The total number of seconds that the player has been directly looking at this object.
		//"Directly" means having a greater lookAtScore than the threshold value.
		return totalLookAtScore;
	}
	public int GetCount()
	{
		//The total number of seconds that the player has been directly looking at this object.
		//"Directly" means having a greater lookAtScore than the threshold value.
		return count;
	}

	private IEnumerator Cycle()
	{
		yield return new WaitForSeconds(Random.Range(0, interval));
		while (true)
		{
				float score = GetLookAtScore();
				if (score > lookAtThreshold)
				{
					totalLookAtScore += interval;
					if (enableCount)
					{
						count = count + 1;
						enableCount = false;
					}
				}
				else
					enableCount = true;
				//lookAtHistory[historyIndex] = score;
				//historyIndex++;
				//historyIndex = historyIndex % lookAtHistory.Length;
				sumScore = score + sumScore;
				averageCounter = averageCounter + 1;
				averageScore = sumScore / averageCounter;

				yield return waitForSeconds;
			

		}
	}
}