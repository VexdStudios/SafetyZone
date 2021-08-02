using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;
using Com.Kawaiisun.SimpleHostile;

public class DiscordController : MonoBehaviour
{
    public Discord.Discord discord;

    void Start()
    {
        discord = new Discord.Discord(863823054013595698, (System.UInt64)Discord.CreateFlags.Default);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity {
            Details = "In multiplayer with " + Manager.killcount + " kills",
            State = "Playing Safety Zone",
            Assets =
            {
                LargeImage = "szicon",
                LargeText = "Playing Safety Zone Online",
                SmallImage = "szicon",
                SmallText = "Safety Zone"
            }
        };
        activityManager.UpdateActivity(activity, (res) => {
            if (res == Discord.Result.Ok)
                Debug.Log("Discord status set!");
            else
                Debug.LogError("Discord status set failed.");
        });
    }

    // Update is called once per frame
    void Update()
    {
        discord.RunCallbacks();
    }
}
