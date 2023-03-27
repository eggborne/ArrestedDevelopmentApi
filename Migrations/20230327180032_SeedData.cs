using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArrestedDevelopmentApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Text" },
                values: new object[,]
                {
                    { 1, "You boys know how to shovel coal?" },
                    { 2, "What do you expect, Mother? I'm half machine!" },
                    { 3, "I'm a monster!" },
                    { 4, "It's a good thing he's already got that little scooter" },
                    { 5, "A heart attack never stopped old Big Bear" },
                    { 6, "I didn't even know we were calling him Big Bear" },
                    { 7, "You could charm the black off a telegram boy" },
                    { 8, "Did you see the new Poof?" },
                    { 9, "I love all of my children equally" },
                    { 10, "No one's called him Baby Buster since high school" },
                    { 11, "They didn't sneak into this country to be your friends" },
                    { 12, "You were just a turd out there, you know?" },
                    { 13, "This party is going to be off the hook" },
                    { 14, "I hear the jury's still out on science" },
                    { 15, "Like anyone would want to \"R\" her" },
                    { 16, "Can't a guy call his mother pretty without it seeming strange?" },
                    { 17, "This is the best free scrapbooking class I've ever taken" },
                    { 18, "Go ahead, touch the Cornballer" },
                    { 19, "I'm going to run this through again on \"pots and pans\"" },
                    { 20, "I've been in the film business for a while but I just can't seem to get one in the can" },
                    { 21, "I will be a bigger and hairier mole than the one on your inner left thigh" },
                    { 22, "I want to cry so bad, but I don't think I can spare the moisture" },
                    { 23, "Maybe it was the other George Michael" },
                    { 24, "I'm tired of trying to find happiness through lies and self-medicating" },
                    { 25, "It's so watery, and yet there's a smack of ham to it" },
                    { 26, "The seal is for marksmanship, and the gorilla is for sand racing" },
                    { 27, "After all these years, God's not going to take a call from you" },
                    { 28, "You mean the guy we're meeting with can't even grow his own hair?" },
                    { 29, "I thought the two of us could talk man-on-man" },
                    { 30, "I spent so much time making sweet love on my wife that it's hard to hear anything over the clatter of her breasts" },
                    { 31, "You've been warned about touching" },
                    { 32, "No touching" },
                    { 33, "I think I maced a crane" },
                    { 34, "Wine only turns to alcohol if you let it sit" },
                    { 35, "I see you've wasted no time in filling my seat hole" },
                    { 36, "I'm going to buy you the single healthiest call girl this town has ever seen" },
                    { 37, "Turn this skiff around" },
                    { 38, "I never thought I'd miss a hand so much" },
                    { 39, "I can just taste those meaty leading man parts in my mouth." },
                    { 40, "Everyone's laughing and riding and cornholing except Buster" },
                    { 41, "You can always tell a Milford man" },
                    { 42, "Let me take off my assistant's skirt and put on my Barbra-Streisand-in-The-Prince-of-Tides ass-masking therapist pantsuit" },
                    { 43, "I don't want no part of yo tight-ass country-club" },
                    { 44, "Don't leave your Uncle T-Bag hanging" },
                    { 45, "What have we always said is the most important thing?" },
                    { 46, "We're just blowing through nap time, aren't we?" },
                    { 47, "Let me give that oatmeal some brown sugar" },
                    { 48, "A sea of waiters and no one will take a drink order" },
                    { 49, "Those are balls" },
                    { 50, "I'm gonna build me an airport, put my name on it" },
                    { 51, "Let me out that queen" },
                    { 52, "Do these effectively hide my thunder?" },
                    { 53, "You just grab that brownish area by its points and you don't let go no matter what your mother tells you" },
                    { 54, "I guess you can say I'm buy-curious" },
                    { 55, "The soup of the day is bread" },
                    { 56, "I could use a leather jacket for when I'm on my hog and have to go into a controlled slide" },
                    { 57, "Are you at all concerned about an uprising?" },
                    { 58, "In the dark, it all looks the same" },
                    { 59, "Look at us, crying like a bunch of girls on the last day of camp" },
                    { 60, "You just made a fool out of yourself in front of T-Bone" },
                    { 61, "I hope you also carry a spare bowl of candy beans" },
                    { 62, "You can't just comb that out and reset it?" },
                    { 63, "Look what the homosexuals have done to me" },
                    { 64, "Everything they do is so dramatic and flamboyant, it just makes me want to set myself on fire" },
                    { 65, "I may have committed some light treason" },
                    { 66, "I don't understand the question and I won't respond to it" },
                    { 67, "There's always money in the banana stand" },
                    { 68, "In this business of show, you have to have the heart of an angel and the hyde of an elephant" },
                    { 69, "Too many lives have been ruined because some cheap waitress at a HoJo said she used an I.U.D." },
                    { 70, "Do you think I could have a hit of that juice box?" },
                    { 71, "Suddenly he's too much of a big shot to brush Mother's hair" },
                    { 72, "It walked on my pillow" },
                    { 73, "That's not a spinner" },
                    { 74, "I thought I saw a graham cracker out there" },
                    { 75, "There's still plenty of meat on that bone" },
                    { 76, "Now you take this home, throw it in a pot, add some broth, a potato" },
                    { 77, "You take this home, throw it in a pot, add some broth, a potato — baby, you got a stew going" },
                    { 78, "Never once touched my per diem" },
                    { 79, "Army had a half day" },
                    { 80, "The mere fact that you call making love \"pop pop\" tells me that you're not ready" },
                    { 81, "I'd have to get up pretty early in the morning to get drunk by 1 o' clock" },
                    { 82, "There are dozens of us" },
                    { 83, "I think you're going to be surprised at some of your phrasing" },
                    { 84, "Stop licking my hand, you horse's ass" },
                    { 85, "I'm afraid I just blue myself" },
                    { 86, "Why don't we just take an ad out in \"I'm Poor\" magazine?" },
                    { 87, "And that's why you always leave a note" },
                    { 88, "It's not your fault your parents were cousins, but here we are" },
                    { 89, "You're going to get some hop-ons" },
                    { 90, "It just seems like there's still light coming in from under the door" },
                    { 91, "I'm leaving my mother for you" },
                    { 92, "You're replacing my mother" },
                    { 93, "Even if it means me taking a chubby, I will suck it up" },
                    { 94, "If she's not going to say anything, I certainly can't help her" },
                    { 95, "I hate this doctor" },
                    { 96, "That's like comparing apples and some fruit nobody's ever heard of" },
                    { 97, "Is that what's going to happen to my hair?" },
                    { 98, "Finally, some good news from this guy" },
                    { 99, "There's no other way to take that" },
                    { 100, "He's lost his left hand, so he's going to be all right" },
                    { 101, "Perhaps an attic shall I seek" },
                    { 102, "Don't call my escorts whores" },
                    { 103, "He's definitely got a type" },
                    { 104, "That's my son, you pothead" },
                    { 105, "God knows they're squinters" },
                    { 106, "Instead of making houses, maybe you should make land on the ocean" },
                    { 107, "Maybe you're not smart either. I didn't know until they told me" },
                    { 108, "I've opened a door here that I regret" },
                    { 109, "What's Spanish for \"I know you speak English\"?" },
                    { 110, "You gave us cereal in an ashtray" },
                    { 111, "My name is Judge" },
                    { 112, "Why can't I have hair and money and him nothing?" },
                    { 113, "There's the woman I'm sexually attracted to" },
                    { 114, "I was trained by Army" },
                    { 115, "I don't want to blame it all on 9/11, but it certainly didn't help" },
                    { 116, "Annyong" },
                    { 117, "Brand new cars don't get waxed" },
                    { 118, "Maybe I'll put it in her brownie" },
                    { 119, "You can sink your arrow into my buttocks any time" },
                    { 120, "I thought it was a pool toy" },
                    { 121, "I wouldn't mind kissing that man between the cheeks" },
                    { 122, "Are those police boats?" },
                    { 123, "A trick is something a whore does for money" },
                    { 124, "Illusions, Michael" },
                    { 125, "Clearly the blue part is the land" },
                    { 126, "I don't know what I expected" },
                    { 127, "Huzzah!" },
                    { 128, "It's a wonderful restaurant" },
                    { 129, "Why are you squeezing me with your body?" },
                    { 130, "He's going to be all right" },
                    { 131, "I was set up by the Brits" },
                    { 132, "Say something that will terrify me" },
                    { 133, "I'll buy you a hundred George Michaels that you can teach to drive" },
                    { 134, "I should be in this Poof" },
                    { 135, "Did somebody say Wonder?" },
                    { 136, "She turns illusions for money" },
                    { 137, "Everything I've said about you can be covered with makeup and a lie about a thyroid problem" },
                    { 138, "He just wants to see boys' Linuses" },
                    { 139, "Half your testicle was hanging out of that thing" },
                    { 140, "Give me an old pro like a Robert Redford" },
                    { 141, "Give my son the juice" },
                    { 142, "You look like the window of a butcher shop" },
                    { 143, "You told me I wasn't fit to serve" },
                    { 144, "They even touched my Charlie Browns" },
                    { 145, "It's tired in here" },
                    { 146, "Make love in your own hand, mother" },
                    { 147, "Sometimes love should be terrifying" },
                    { 148, "My Army training tells me that this is going to be a hot mission" },
                    { 149, "I don't date whores" },
                    { 150, "It's just mom and whores" },
                    { 151, "Can't you keep my hand to yourself?" },
                    { 152, "Have you seen my rubber hand?" },
                    { 153, "I've always loved those leathery little snappy faces" },
                    { 154, "Soft and alive" },
                    { 155, "It wasn't really the pronunciation that bothered me" },
                    { 156, "My hook is stuck in the stair car" },
                    { 157, "And that's why you don't use one-armed persons to teach lessons" },
                    { 158, "He's a robot!" },
                    { 159, "If the only thing I could do was lay in bed all day and eat soup, I'd be happy" },
                    { 160, "I could just take it through a tube" },
                    { 161, "Never let me die" },
                    { 162, "When I miss your lips, I'll put a fig in my mouth" },
                    { 163, "My love thinks I'm a coward just because I wasted precious hospital resources to avoid my legal obligation" },
                    { 164, "I've always pictured him in a lighthouse" },
                    { 165, "I need to be rubbing elbows, not working your fork" },
                    { 166, "The ocean is my second biggest fear" },
                    { 167, "I hope that's not a crack about my hair color, lips, forehead, nose and teeth because at least I'm not the wearing a round sweater set on my face" },
                    { 168, "You're looking at balls here" },
                    { 169, "I've seen the blood" },
                    { 170, "Imagine the impact if that had come on right when we turned on the TV" },
                    { 171, "Cool your Japanese jets" },
                    { 172, "You forgot to say \"away\" again" },
                    { 173, "Look at the beak on that bird" },
                    { 174, "I think the name Michael is making you look for a man" },
                    { 175, "You can just say \"intercourse\"" },
                    { 176, "We just say \"manager\"" },
                    { 177, "Doesn't matter who" },
                    { 178, "I'd rather be dead in California than alive in Arizona" },
                    { 179, "I call it hot ham water" },
                    { 180, "He's a regular Freddie Wilson, that one" },
                    { 181, "Don't call it that" },
                    { 182, "If you didn't have adult onset diabetes, I wouldn't mind giving you a little sugar" },
                    { 183, "You don't want a hungry dove down your pants" },
                    { 184, "That's how Tony Wonder lost a nut" },
                    { 185, "Why go to a banana stand when we can make YOUR banana stand?" },
                    { 186, "Don't worry, these young beauties have been nowhere near the bananas" },
                    { 187, "And that's why you don't try to teach lessons to your father" },
                    { 188, "We'll be the laughing stock of the boardwalk" },
                    { 189, "If you feel something moving down there, it's just the bird" },
                    { 190, "I might have you beaten with a pillowcase full of batteries" },
                    { 191, "The guy runs a prison; he can have any piece of ass he wants" },
                    { 192, "Who's the \"her\" in that sentence?" },
                    { 193, "Please don't call yourself that" },
                    { 194, "I don't know why I always assume that everyone has read my screenplay" },
                    { 195, "I'm not going to spend this kind of money and not watch" },
                    { 196, "He showers her with club sauce" },
                    { 197, "You've never told me how many houses there are in the British Parliament" },
                    { 198, "I think we could be more than just gym buddies" },
                    { 199, "You're blowing my mind, Frank" },
                    { 200, "The whole backside has moles" },
                    { 201, "There's no \"I\" in \"win\"" },
                    { 202, "Within her lies a queen" },
                    { 203, "You can control your bladder when you're dead" },
                    { 204, "I ought to pull down your pants and spank your ass raw" },
                    { 205, "Why should you go to jail for a crime someone else noticed?" },
                    { 206, "I was a professional twice over: an analyst and a therapist" },
                    { 207, "The world's first analrapist" },
                    { 208, "I shall drop you off alive, hooker or no" },
                    { 209, "They're polite and the men all sound gay, but they will rip out your heart" },
                    { 210, "I almost had Pop-Pop in Reno" },
                    { 211, "If this tableau I recreate, perhaps I can re-snare my mate" },
                    { 212, "I don't want anybody to go inside that musty claptrap" },
                    { 213, "We were both waiting for our dads at that garden where the little boy found the arm" },
                    { 214, "I kind of feel like that kid who found the severed hand" },
                    { 215, "I don't see you crying, robot" },
                    { 216, "Say goodbye to these" },
                    { 217, "I promised myself I wasn't going to become one of those people who were always going on about their screenplays" },
                    { 218, "Nobody sells any coke in this pen without daddy getting a taste" },
                    { 219, "You haven't seen a little box with a turtle on it, have you?" },
                    { 220, "My turtle was living in it before he ate all the grass and died" },
                    { 221, "The scabs come right off" },
                    { 222, "I can't say no to the woman who gave me chlamydia" },
                    { 223, "People hear the name Tobias, they think big black guy" },
                    { 224, "I just don't want people's kids getting their sticky little fingers all over these $2,600 pants" },
                    { 225, "The guy who's dirty dancing with his niece is going to tell the guy in the $3,600 suit how to run the business. Come on" },
                    { 226, "Suddenly playing with yourself is a scholarly pursuit" },
                    { 227, "If I wanted something your thumb touched, I'd eat the inside of your ear" },
                    { 228, "You let him go in the sun?" },
                    { 229, "Then why don't you marry an ice cream sandwich?" },
                    { 230, "I will pack your sweet pink mouth with so much ice cream you'll be the envy of every Jerry and Jane on the block" },
                    { 231, "I am having a love affair with this ice cream sandwich" },
                    { 232, "Did you stick it to her?" },
                    { 233, "Pop-Pop needs your hair" },
                    { 234, "At least he's in prison, not an urn" },
                    { 235, "You know the hair that no one's supposed to see?" },
                    { 236, "Everyone put on white robes and outsmarted us" },
                    { 237, "We shan't be telling your mother about this, shan't we?" },
                    { 238, "Now there's somebody who needs a good mother" },
                    { 239, "I'll leave when I'm good and ready" },
                    { 240, "I need one of those necklaces in the shape of a T" },
                    { 241, "There's a cream with real diamonds in it" },
                    { 242, "You, sir, are a mouthful" },
                    { 243, "If I can't find a horny immigrant by then, I don't deserve to stay here" },
                    { 244, "There's a man inside me, and only when he's finally out can I walk free of pain" },
                    { 245, "I'm afraid I prematurely shot my wad on what was supposed to be a \"dry run\", if you will, so now I'm afraid I have something of a mess on my hands" },
                    { 246, "I've made a huge mistake" },
                    { 247, "You are playing adults with fully-formed libidos, not two young men playing grab-ass in the shower" },
                    { 248, "I can't go on a million bike rides whenever you want me to" },
                    { 249, "The doctor said there were claw marks on the walls of her uterus" },
                    { 250, "It's like she gets off on being withholding" },
                    { 251, "Look who's ragging on the old lady" },
                    { 252, "Look at me, \"getting off\"" },
                    { 253, "I always ended up on all fours" },
                    { 254, "This kind of agility?" },
                    { 255, "Do you see me more as the respected dramatic actor or more of the beloved comic actor?" },
                    { 256, "I don't even want to tell you what she wouldn't let me do to her in the car" },
                    { 257, "I thought you had class" },
                    { 258, "Carl Weathers took everything from me" },
                    { 259, "You could have been sleeping with Frightened Inmate #2" },
                    { 260, "Some call me The Human Metronome" },
                    { 261, "So far it's been all chain and no ball" },
                    { 262, "Not everything is strippers and booze and buckets of blood" },
                    { 263, "You're out of the band" },
                    { 264, "I've already got a Lucille in my life" },
                    { 265, "Is this something society will allow?" },
                    { 266, "I just jumped through a plate glass window on a date" },
                    { 267, "I have been Googling your father" },
                    { 268, "I sold you for a pack of cigarettes" },
                    { 269, "You don't fire crazy" },
                    { 270, "All these books are cooked" },
                    { 271, "It's like a mind puzzle, an awesome mind puzzle" },
                    { 272, "Talk you off of what, Pop-Pop?" },
                    { 273, "Where once there was a yacht, now there is naught" },
                    { 274, "Who doesn't love the Jews?" },
                    { 275, "I was going to smoke the marijuana like a cigarette" },
                    { 276, "They don't allow you to have bees in here" },
                    { 277, "I think something laid eggs on me" },
                    { 278, "Mother say no carbohydrate for you if you ever going to get girlfriend that's not old lady" },
                    { 279, "Maybe we should kiss again to teach them a lesson about obvious" },
                    { 280, "Look how he zips now" },
                    { 281, "I should have never taken the pumps out of here" },
                    { 282, "You just can't deal with the fact that I've got a super-thin wife with huge cans" },
                    { 283, "Did you know that you can get a refill on any drink you want here, and it's free?" },
                    { 284, "Aren't you the sweetest thing, spending some time with what's left of your uncle" },
                    { 285, "He couldn't wait to swoop in and throw on the sailor suit" },
                    { 286, "I got children all over town" },
                    { 287, "My father is my uncle" },
                    { 288, "That's the kind of joke he would have loved" },
                    { 289, "Who'd like a banger in the mouth?" },
                    { 290, "We just call it a sausage" },
                    { 291, "Franklin said some things Whitey just wasn't ready to hear" },
                    { 292, "I forgot that we were in the colonies" },
                    { 293, "Take me to your secular world" },
                    { 294, "My socks are wet" },
                    { 295, "Me quick, want slow" },
                    { 296, "Tea for dong!" },
                    { 297, "I'd want to get in there and find some answers" },
                    { 298, "Excuse me for liking the way they shape my junk" },
                    { 299, "It's not just going to be my love and George Michael's, but God's love as well" },
                    { 300, "Can it open a can?" },
                    { 301, "A seal didn't bite your Linus off, right?" },
                    { 302, "No, a seal didn't bite my Linus off" },
                    { 303, "Up yours, granny!" },
                    { 304, "You couldn't handle it!" },
                    { 305, "Seems like only yesterday you were bursting forth from your mother's fertile womb" },
                    { 306, "You don't see me nervous about being on my third Virgin Mary" },
                    { 307, "You are a worse psychiatrist than you are a son-in-law, and you will never get work as an actor because you have no talent" },
                    { 308, "I had no idea a ninety year-old man could cave in my chest cavity like that" },
                    { 309, "I think your knee is on my heart" },
                    { 310, "I'm afraid I prematurely shot my wad on what was supposed to be a dry run, if you will" },
                    { 311, "I'm going to see if I can get a wrench to strip my nuts" },
                    { 312, "I haven't had a massage since prison" },
                    { 313, "He's an alpaca" },
                    { 314, "One of this guy's eyebrows just fell in the bowl of candy beans" },
                    { 315, "I think George Michael is hiding Ann in the attic" },
                    { 316, "It's as Ann as the nose on Plain's face" },
                    { 317, "I have Pop-Pop in the attic" },
                    { 318, "Who wants to go to the hospital?" },
                    { 319, "That was 100% inappropriate, and I do apologize profusely" },
                    { 320, "I ought to point to Uncle Oscar's Charlie Browns next time you're on top of him, Mother" },
                    { 321, "I figured if I blue myself early I'd be nice and relaxed for a 9:00 dinner reservation" },
                    { 322, "I can actually smear diamonds on my face, and it's only $400 a tub" },
                    { 323, "She calls it a 'mayon-egg'" },
                    { 324, "Mom volunteered me for the Army just because the fat man dared her to" },
                    { 325, "The tears just aren't coming" },
                    { 326, "You mean you can wear stripper clothes when you're not stripping?" },
                    { 327, "You could hump that hood" },
                    { 328, "What a fun sexy time for you" },
                    { 329, "What I'm calling you is a television actor" },
                    { 330, "There's only one man I've ever called a coward, and that's Brian Doyle Murray" },
                    { 331, "We do not wag our genitals at one another to make a point" },
                    { 332, "It's a mainstay of the magician's toolkit, like how clowns always have a rag soaked in ether" },
                    { 333, "The worst that could happen is that I could spill coffee all over this $3,000 suit" },
                    { 334, "I came out of you, he didn't" },
                    { 335, "I liked it better when he just said Annyong" },
                    { 336, "Maybe it was the eleven months he spent in the womb" },
                    { 337, "You dont cry when you take those off?" },
                    { 338, "How many times I gotta tell this kid chicken wings?" },
                    { 339, "Somebody is a rude Gus" },
                    { 340, "I can't even fake the death of a stripper" },
                    { 341, "You didn't eat that dove, did you?" },
                    { 342, "If someone had left a note, this innocent man would still have his arm" },
                    { 343, "You'd think a man locked up in prison would able to abstain" },
                    { 344, "Your father with his disgusting tweaking" },
                    { 345, "I couldn't breast feed any of you kids because of that man" },
                    { 346, "This is the nicest she's been since she found out that Rosa could breast-feed Buster" },
                    { 347, "First you dump all over it, now you want to know how it's done" },
                    { 348, "I feel like the prettiest girl at the dance" },
                    { 349, "I need to go take down the buffet and set up the leather pony" },
                    { 350, "They cannot arrest a husband and wife for the same crime" },
                    { 351, "Say what you want about America - thirteen bucks can still get you a hell of a lot of mice" },
                    { 352, "Who said anything bad about America?" },
                    { 353, "So I'm thinking of getting a motorcycle" },
                    { 354, "Your legs look exactly like mine, and I just shaved mine" },
                    { 355, "I'm looking for something that says \"Dad likes leather\"" },
                    { 356, "You have to be some sort of she-hulk to get this" },
                    { 357, "Mom, you're ruining our fort" },
                    { 358, "Who'd want to mess with any of us?" },
                    { 359, "Trying to introduce some edge to the whole palette" },
                    { 360, "Is she the one who's going to take him to the dentist?" },
                    { 361, "You're right inside me now" },
                    { 362, "I can't believe they wouldn't even give me a wheelchair ride" },
                    { 363, "Doesn't this make you want to have an ice-cream cone?" },
                    { 364, "I do believe there was some mention of some ice cream" },
                    { 365, "Does anyone know how to eat one of these?" },
                    { 366, "There's a new daddy in town. A discipline daddy." },
                    { 367, "I tried hitchhiking, but it's hard to do without a thumb" },
                    { 368, "Now what we do is we paint our lips Joan Crawford red, pop on a little blue eyeliner and then plant a lipstick kiss on every one of them" },
                    { 369, "Still, where'd the lighter fluid come from?" },
                    { 370, "Larry, go to a mirror" },
                    { 371, "Why am I not going under water?" },
                    { 372, "Why did I lose all the weight if they're going to put me in a pool cover?" },
                    { 373, "I wish I could draw her nose" },
                    { 374, "I just found out that my cellular telephone was a lemon" },
                    { 375, "Are you wearing my dead wife's maternity clothes?" },
                    { 376, "I can't get this ham open" },
                    { 377, "If he's got a shot with her, just give me a little tap on the fanny" },
                    { 378, "Now, when you do this without getting punched in the chest, you'll have more fun" },
                    { 379, "The Blue Man Group might need me, and I do deserve a fancy phone" },
                    { 380, "The doctor said I couldn't be a mother now if I tried" },
                    { 381, "I'm much, much, much older than 15" },
                    { 382, "And the worst part is he thinks he's passing" },
                    { 383, "Wow, that does sound like a little girl" },
                    { 384, "I'm going for a hot Ding Dong" },
                    { 385, "She said “tingling” like 75 times" },
                    { 386, "You smell like a pine cone" },
                    { 387, "I'm on bad mushrooms" },
                    { 388, "This close, they always look like landscape" },
                    { 389, "There were cutoffs up here?" },
                    { 390, "What are you doing with Mother's rape horn?" },
                    { 391, "Do you want to steer, or are you too old to sit on your pop's lap and drive?" },
                    { 392, "They impounded my humble trailer" },
                    { 393, "Does this look contagious to you?" },
                    { 394, "Nice to be back in a queen" },
                    { 395, "Let the great experiment begin" },
                    { 396, "There's got to be a better way to say that" },
                    { 397, "I am having the time of my life" },
                    { 398, "I haven't met Ann" },
                    { 399, "I kind of want to buy her a diamond" },
                    { 400, "I'm sure that Egg is a very nice person" },
                    { 401, "I heard zoo noises" },
                    { 402, "Which pinky do you use less?" },
                    { 403, "Nothing on the inside" },
                    { 404, "I'm not proud of the way I was so grossed out when I found out you were gross before" },
                    { 405, "I'm just hoping to get mildly injured so I can get out of the Army" },
                    { 406, "I think my nipples are bleeding" },
                    { 407, "Flashes of Quincy" },
                    { 408, "I think the plant lady's wearing a thong" },
                    { 409, "Don't be such an Ann hog" },
                    { 410, "Go see a Star War" },
                    { 411, "Why am I not blacking out?" },
                    { 412, "He swore by that Glisten" },
                    { 413, "Let's go dig up your uncle" },
                    { 414, "I will be head to toe in blue makeup until 8:01 in case the Blue Man Group needs their understudy" },
                    { 415, "Are we having yams?" },
                    { 416, "First I blow him, then I poke him" },
                    { 417, "I don't think we need people trying to compete with what I'm wearing" },
                    { 418, "Don't ask me, I'm just the boy's father" },
                    { 419, "No one would believe that a woman like me would have a gay son" },
                    { 420, "I can see marinating a chicken in that" },
                    { 421, "Your Tweety Bird dance just cost us a run, you moron" },
                    { 422, "How do we filter out the teases? We don't let them in." },
                    { 423, "I am stable as a table" },
                    { 424, "I would hardly call my mother a girl, but yes, she's still very much a part of my life" },
                    { 425, "Everybody thinks they're Frank Sinatra" },
                    { 426, "They make me feel dressier" },
                    { 427, "A piano could stand on those legs" },
                    { 428, "Guess she didn't see the drawings" },
                    { 429, "You have undone all of Dr. Sandor Plumb's work" },
                    { 430, "I need to prove to her that I'm not just a man, but a man's man" },
                    { 431, "Shall I put the Posturepedic in the down position?" },
                    { 432, "Read me the appetizers again" },
                    { 433, "Did you have too much club sauce on your calamari?" },
                    { 434, "I tried to drink some of the water, and it was too hot and it tasted like soy sauce" },
                    { 435, "I think the teriyaki chicken burst" },
                    { 436, "This isn't turning into the party hangout I hoped" },
                    { 437, "Stick a wrench in me, I'm done" },
                    { 438, "Someone order 140 pounds of upper-body strength?" },
                    { 439, "It's just something the body does when you shake it" },
                    { 440, "Well, I'm all grown up now" },
                    { 441, "How'd you like to take a nap, baldy?" },
                    { 442, "Let's not spin in the comfy chair" },
                    { 443, "I got Michael out of his marriage, didn't I?" },
                    { 444, "I need macaroons" },
                    { 445, "You can win every argument like that, but that does not make you right" },
                    { 446, "I really hate it when you put on the God costume" },
                    { 447, "I'm cloaking myself in her scent" },
                    { 448, "I was made to understand that there would be grilled cheese sandwiches here" },
                    { 449, "Will someone please have the decency to punch me in the face?" },
                    { 450, "Mom always taught us to curl up in a ball and remain motionless when confronted" },
                    { 451, "We have unlimited juice?" },
                    { 452, "You old horny slut" },
                    { 453, "We all know you're Annyong" },
                    { 454, "No, Mother, I can blow myself" },
                    { 455, "Her?" },
                    { 456, "She was made in a cup, like soup" },
                    { 457, "Oh, I'm sorry, I forgot: your wife is dead" },
                    { 458, "The one thing I will never do is not tell him that I'm taking him to a cabin in the woods and then not take him" },
                    { 459, "He was our miracle baby" },
                    { 460, "It's like my heart is getting hard" },
                    { 461, "I know what an erection feels like, Michael" },
                    { 462, "Those aren't even birds" },
                    { 463, "But I'm white" },
                    { 464, "It ain't easy being white" },
                    { 465, "I'm Mom and I want to shoot down everything you say so I feel good about myself" },
                    { 466, "Lets deal some drugs" },
                    { 467, "Why do you think I wear these?" },
                    { 468, "A magician never reveals his secrets" },
                    { 469, "When's that voice gonna drop?" },
                    { 470, "I'm gonna go get sexy" },
                    { 471, "They said he was some kind of scientist" },
                    { 472, "Speaking of settling, How's Ann?" },
                    { 473, "It's hard to gauge time" },
                    { 474, "I like the way they think" },
                    { 475, "I was hoping he would be gifted sexually" },
                    { 476, "If this were a Lifetime Moment of Truth movie, this would be our act break" },
                    { 477, "A flower in my garden, a mystery in my panties" },
                    { 478, "I'm a scholar. I enjoy scholarly pursuits" },
                    { 479, "The warden could easily be black" },
                    { 480, "Who is this shiny building of a man?" },
                    { 481, "Chickens don't clap" },
                    { 482, "I've got a stair car full of Mexican laborers that would love a day's work" },
                    { 483, "Are beads cheap?" },
                    { 484, "We'll see who brings in more honey" },
                    { 485, "He's thinking about bees again" },
                    { 486, "We're going to have to figure out something to do so that people can look at you without wanting to kill themselves" },
                    { 487, "You don’t know a good bird hospital, do you?" },
                    { 488, "Hair up, glasses off" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 488);
        }
    }
}
