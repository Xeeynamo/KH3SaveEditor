using KHSave.Attributes;
using KHSave.LibDDD.Attributes;
using System;

// thank you HOLLOW_DRAGONITE for this list of ID's you made my life a lot easier

namespace KHSave.LibDDD.Types
{
    internal enum ItemType
    {
        CommandDeck = 0 << 8,
        Keyblade = 2 << 8,
        Recipe = 3 << 8,
        KeyItem = 4 << 8,
        Glossary = 5 << 8,
        DreamPiece = 6 << 8,
        TrainingFood = 7 << 8,
        TrainingToy = 8 << 8,
        Memento = 9 << 8,
    }

    public enum EquipmentType : short
    {
        [Info("Empty")] Empty,
        [Movement("Jump")] Jump,
        [Movement("High Jump")] HighJump,
        [Movement("Dodge Roll")] DodgeRoll,
        [Movement("Slide Roll")] SlideRoll,
        [Movement("Dark Roll")] DarkRoll,
        [Movement("Air Slide")] AirSlide,
        [Movement("Sonic Impact")] SonicImpact,
        [Movement("Double Impact")] DoubleImpact,
        [Movement("Glide")] Glide,
        [Movement("Superglide")] Superglide,
        [Movement("Shadow Slide")] ShadowSlide,
        [Movement("Doubleflight")] Doubleflight,
        [Defense("Block")] Block,
        [Defense("Wake-Up Block")] WakeUpBlock,
        [Defense("Link Block")] LinkBlock,
        [Defense("Sliding Block")] SlidingBlock,
        [Defense("Dark Barrier")] DarkBarrier,
        [Reprisal("Counter Rush")] CounterRush,
        [Reprisal("Counter Aura")] CounterAura,
        [Reprisal("Shadow Strike")] ShadowStrike,
        [Reprisal("Payback Raid")] PaybackRaid,
        [Reprisal("Payback Blast")] PaybackBlast,
        [Reprisal("Aerial Recovery")] AerialRecovery,
        [Reprisal("Steep Climb")] SteepClimb,
        [Reprisal("Rapid Descent")] RapidDescent,
        [Reprisal("Sliding Sidewinder")] SlidingSidewinder,
        [Reprisal("Sliding Crescent")] SlidingCrescent,
        [FlowMotion("Wall Kick")] WallKick,
        [FlowMotion("Pole Spin")] PoleSpin,
        [FlowMotion("Pole Swing")] PoleSwing,
        [FlowMotion("Rail Slide")] RailSlide,
        [FlowMotion("Superslide")] Superslide,
        [FlowMotion("Superjump")] Superjump,
        [FlowMotion("Kick Dive")] KickDive,
        [FlowMotion("Buzz Saw")] BuzzSaw,
        [FlowMotion("Blow-Off")] BlowOff,
        [FlowMotion("Wheel Rush")] WheelRush,
        [FlowMotion("Sliding Dive")] SlidingDive,
        [FlowMotion("Shock Dive")] ShockDive,
        [Attack("Quick Blitz")] QuickBlitz,
        [Attack("Blizzard Edge")] BlizzardEdge,
        [Attack("Dark Break")] DarkBreak,
        [Attack("Slot Edge")] SlotEdge,
        [Attack("Blitz")] Blitz,
        [Attack("Meteor Crash")] MeteorCrash,
        [Attack("Spark Dive")] SparkDive,
        [Attack("Poison Dive")] PoisonDive,
        [Attack("Drain Dive")] DrainDive,
        [Attack("Sliding Dash")] SlidingDash,
        [Attack("Thunder Dash")] ThunderDash,
        [Attack("Sonic Blade")] SonicBlade,
        [Attack("Dark Aura")] DarkAura,
        [Attack("Zantetsuken")] Zantetsuken,
        [Attack("Strike Raid")] StrikeRaid,
        [Attack("Spark Raid")] SparkRaid,
        [Attack("Circle Raid")] CircleRaid,
        [Attack("Aerial Slam")] AerialSlam,
        [Attack("Ars Arcanum")] ArsArcanum,
        [Attack("Dark Splicer")] DarkSplicer,
        [Attack("Gravity Strike")] GravityStrike,
        [Attack("Confusing Strike")] ConfusingStrike,
        [Attack("Tornado Strike")] TornadoStrike,
        [Attack("Prism Windmill")] PrismWindmill,
        [Attack("Timestorm")] Timestorm,
        [Attack("Fire Windmill")] FireWindmill,
        [Attack("Icebreaker")] Icebreaker,
        [Attack("Shadowbreaker")] Shadowbreaker,
        [Attack("Magnet Spiral")] MagnetSpiral,
        [Attack("Salvation")] Salvation,
        [Attack("Limit Storm")] LimitStorm,
        [Attack("Collision Magnet")] CollisionMagnet,
        [Attack("Sacrifice")] Sacrifice,
        [Attack("Break Time")] BreakTime,
        [Magic("Fire")] Fire,
        [Magic("Fira")] Fira,
        [Magic("Firaga")] Firaga,
        [Magic("Dark Firaga")] DarkFiraga,
        [Magic("Firaga Burst")] FiragaBurst,
        [Magic("Mega Flare")] MegaFlare,
        [Magic("Blizzard")] Blizzard,
        [Magic("Blizzara")] Blizzara,
        [Magic("Blizzaga")] Blizzaga,
        [Magic("Icicle Splitter")] IcicleSplitter,
        [Magic("Deep Freeze")] DeepFreeze,
        [Magic("Ice Barrage")] IceBarrage,
        [Magic("Thunder")] Thunder,
        [Magic("Thundara")] Thundara,
        [Magic("Thundaga")] Thundaga,
        [Magic("Triple Plasma")] TriplePlasma,
        [Magic("Cure")] Cure,
        [Magic("Cura")] Cura,
        [Magic("Curaga")] Curaga,
        [Magic("Esuna")] Esuna,
        [Magic("Zero Gravity")] ZeroGravity,
        [Magic("Zero Gravira")] ZeroGravira,
        [Magic("Zero Graviga")] ZeroGraviga,
        [Magic("Zero Graviza")] ZeroGraviza,
        [Magic("Balloon")] Balloon,
        [Magic("Balloonra")] Balloonra,
        [Magic("Balloonga")] Balloonga,
        [Magic("Spark")] Spark,
        [Magic("Sparkra")] Sparkra,
        [Magic("Sparkga")] Sparkga,
        [Magic("Faith")] Faith,
        [Magic("Tornado")] Tornado,
        [Magic("Meteor")] Meteor,
        [Magic("Mini")] Mini,
        [Magic("Blackout")] Blackout,
        [Magic("Time Bomb")] TimeBomb,
        [Magic("Confuse")] Confuse,
        [Magic("Bind")] Bind,
        [Magic("Poison")] Poison,
        [Magic("Slow")] Slow,
        [Magic("Sleep")] Sleep,
        [Magic("Sleepra")] Sleepra,
        [Magic("Sleepga")] Sleepga,
        [Magic("Stop")] Stop,
        [Magic("Vanish")] Vanish,
        [Consumable("Potion")] Potion,
        [Consumable("Hi-Potion")] HiPotion,
        [Consumable("Mega-Potion")] MegaPotion,
        [Consumable("Drop-Me-Not")] DropMeNot,
        [Consumable("Drop-Me-Never")] DropMeNever,
        [Consumable("Panacea")] Panacea,
        [Consumable("Elixir")] Elixir,
        [Consumable("Megalixir")] Megalixir,
        [Consumable("Dream Candy")] DreamCandy,
        [Info("Protect")] Protect,
        [Info("Shell")] Shell,
        [Info("Regen")] Regen,
        [Info("Haste")] Haste,
        [Info("Drain")] Drain,
        [Info("Combo Assist")] ComboAssist,
        [Info("Auto-Life")] AutoLife,
        [Info("Spirit Roar")] SpiritRoar,
        [Info("DUMMY")] DUMMY,
        [Info("Attack")] Attack,
        [Info("Save")] Save,
        [Info("Talk")] Talk,
        [Info("Open")] Open,
        [Info("Examine")] Examine,
        [Info("Shop")] Shop,
        [Info("Rescue")] Rescue,
        [Info("Finish")] Finish,
        [Info("Nightmare Clash")] NightmareClash,
        [Info("Finish")] Finish146,
        [Info("DUMMY")] DUMMY147,
        [Info("Link Portal")] LinkPortal,
        [Info("Meow Wounce")] MeowWounce,
        [Info("Berserker Bronco")] BerserkerBronco,
        [Info("Unwind")] Unwind,
        [Info("Debug Jump")] DebugJump,
        [Info("? ? ?")] Unnamed153,
        [Info("Meow Wounce")] MeowWounce154,
        [Info("Roll Call")] RollCall,
        [Info("Whirling Bronco")] WhirlingBronco,
        [Info("Fly-By Knight")] FlyByKnight,
        [Info("Hammer Throw")] HammerThrow,
        [Info("Flame Thrower")] FlameThrower,
        [Info("Decussation")] Decussation,
        [Info("Poison Dash")] PoisonDash,
        [Info("Water Blaster")] WaterBlaster,
        [Info("Bubble Blaster")] BubbleBlaster,
        [Info("Paw Groove")] PawGroove,
        [Info("Equestrian Raid")] EquestrianRaid,
        [Info("Swing Fling")] SwingFling,
        [Info("Equestrian Raid")] EquestrianRaid167,
        [Info("Belly Raid")] BellyRaid,
        [Info("Fly-By Knight")] FlyByKnight169,
        [Info("Roll Call")] RollCall170,
        [Info("Target Shot")] TargetShot,
        [Info("Cure Sun")] CureSun,
        [Info("Vacuum Ghost")] VacuumGhost,
        [Info("Berserker Bronco")] BerserkerBronco174,
        [Info("Lucky Dice")] LuckyDice,
        [Info("Fly-By Knight")] FlyByKnight176,
        [Info("Trap Shot")] TrapShot,
        [Info("Water Blaster")] WaterBlaster178,
        [Info("Meow Wounce")] MeowWounce179,
        [Info("Whirling Bronco")] WhirlingBronco180,
        [Info("Decussation")] Decussation181,
        [Info("Decussation")] Decussation182,
        [Info("Fire Blaster")] FireBlaster,
        [Info("Equestrian Raid")] EquestrianRaid184,
        [Info("Poison Rain")] PoisonRain,
        [Info("Vacuum Ghost")] VacuumGhost186,
        [Info("Fly-By Knight")] FlyByKnight187,
        [Info("Swing Fling")] SwingFling188,
        [Info("Roll Call")] RollCall189,
        [Info("Flame Raid")] FlameRaid,
        [Info("Swing Fling")] SwingFling191,
        [Info("Roll Call")] RollCall192,
        [Info("Ice Raid")] IceRaid,
        [Info("Tail Groove")] TailGroove,
        [Info("Aura Raid")] AuraRaid,
        [Info("Decussation")] Decussation196,
        [Info("Tail Groove")] TailGroove197,
        [Info("Aura Raid")] AuraRaid198,
        [Info("Meow Wounce")] MeowWounce199,
        [Info("Flame Thrower")] FlameThrower200,
        [Info("Paw Groove")] PawGroove201,
        [Info("Swing Fling")] SwingFling202,
        [Info("Target Shot")] TargetShot203,
        [Info("Lucky Dice")] LuckyDice204,
        [Info("Ragnarok")] Ragnarok,
        [Info("Prism Light")] PrismLight,
        [Info("Chaos Snake")] ChaosSnake,
        [Info("Trinity Limit")] TrinityLimit,
        [Info("Ice Wave")] IceWave,
        [Info("Whomperstomp")] Whomperstomp,
        [Info("Comet")] Comet,
        [Info("Unison Rush")] UnisonRush,
        [Info("Dream Shot")] DreamShot,
        [Info("Shadowblade")] Shadowblade,
        [Info("? ? ?")] Unknown215,
        [Info("Shining Hammer")] ShiningHammer,
        [Info("Fire Raid")] FireRaid,
        [Info("Wavesurfer")] Wavesurfer,
        [Info("Thunderstorm")] Thunderstorm,
        [Info("Darkest Fears")] DarkestFears,
        [Info("Rising Wing")] RisingWing,
        [Info("Bladecharge")] Bladecharge,
        [Info("Ghost Drive")] GhostDrive,
        [Info("Tron")] Tron,
        [Info("Code Break")] CodeBreak,
        [Info("Wonder Comic")] WonderComic,
        [Info("Bubble Burst")] BubbleBurst,
        [Info("Melody Catcher")] MelodyCatcher,
        [Info("Slingshot")] Slingshot,
        [Info("Faithline")] Faithline,
        [Info("Nightmare's End")] NightmareEnd,
        [Info("Mirage Split")] MirageSplit,
        [Info("? ? ?")] Unnamed232,
        [Info("? ? ?")] Unnamed233,
        [Info("? ? ?")] Unnamed234,
        [AbilityStats("HP Boost")] HPBoost,
        [AbilityStats("Fire Boost")] FireBoost,
        [AbilityStats("Blizzard Boost")] BlizzardBoost,
        [AbilityStats("Thunder Boost")] ThunderBoost,
        [AbilityStats("Water Boost")] WaterBoost,
        [AbilityStats("Cure Boost")] CureBoost,
        [AbilityStats("Item Boost")] ItemBoost,
        [AbilityStats("Attack Haste")] AttackHaste,
        [AbilityStats("Magic Haste")] MagicHaste,
        [AbilityStats("Attack Boost")] AttackBoost,
        [AbilityStats("Magic Boost")] MagicBoost,
        [AbilityStats("Defense Boost")] DefenseBoost,
        [AbilityStats("Fire Screen")] FireScreen,
        [AbilityStats("Blizzard Screen")] BlizzardScreen,
        [AbilityStats("Thunder Screen")] ThunderScreen,
        [AbilityStats("Water Screen")] WaterScreen,
        [AbilityStats("Dark Screen")] DarkScreen,
        [AbilityStats("Light Screen")] LightScreen,
        [AbilityStats("Mini Block")] MiniBlock,
        [AbilityStats("Blindness Block")] BlindnessBlock,
        [AbilityStats("Confusion Block")] ConfusionBlock,
        [AbilityStats("Bind Block")] BindBlock,
        [AbilityStats("Poison Block")] PoisonBlock,
        [AbilityStats("Slow Block")] SlowBlock,
        [AbilityStats("Sleep Block")] SleepBlock,
        [AbilityStats("Stop Block")] StopBlock,
        [AbilityStats("Reload Boost")] ReloadBoost,
        [AbilityStats("Defender")] Defender,
        [AbilitySupport("Combo Plus")] ComboPlus,
        [AbilitySupport("Air Combo Plus")] AirComboPlus,
        [AbilitySupport("Combo Master")] ComboMaster,
        [AbilitySupport("EXP Boost")] EXPBoost,
        [AbilitySupport("EXP Walker")] EXPWalker,
        [AbilitySupport("EXP Zero")] EXPZero,
        [AbilitySupport("Damage Syphon")] DamageSyphon,
        [AbilitySupport("Second Chance")] SecondChance,
        [AbilitySupport("Once More")] OnceMore,
        [AbilitySupport("Scan")] Scan,
        [AbilitySupport("Leaf Bracer")] LeafBracer,
        [AbilitySupport("Treasure Magnet")] TreasureMagnet,
        [AbilitySpirits("Link Critical")] LinkCritical,
        [AbilitySpirits("Support Boost")] SupportBoost,
        [AbilitySpirits("Waking Dream")] WakingDream,
        [Info("? ? ?")] Unknown279,
        [Info("? ? ?")] Unknown280,
        [Info("Link Accelerator")] LinkAccelerator,
        [Info("Flowmotion Turbo")] FlowmotionTurbo,
        [Info("Drop Decelerator")] DropDecelerator,
        [Info("Attack Gain")] AttackGain,
        [Info("Magic Gain")] MagicGain,
        [Info("Defense Gain")] DefenseGain,
        [Info("Affinity Gain")] AffinityGain,
        [Info("Spirit Auto-Life")] SpiritAutoLife,
        [Info("Ordinary Day")] OrdinaryDay,
        [Info("HP Showers")] HPShowers,
        [Info("Munnystorm")] Munnystorm,
        [Info("Treasure Front")] TreasureFront,
        [Info("Bargain Flurry")] BargainFlurry,
        [Info("Risky Winds")] RiskyWinds,
        [Info("Overcast")] Overcast,
        [Info("? ? ?")] Unknown296,
        [Info("HP Prize S")] HPPrizeS,
        [Info("HP Prize L")] HPPrizeL,
        [Info("Munny Prize S")] MunnyPrizeS,
        [Info("Munny Prize M")] MunnyPrizeM,
        [Info("Munny Prize L")] MunnyPrizeL,
        [Info("Droplet S")] DropletS,
        [Info("Droplet L")] DropletL,
        [Info("Prize Box")] PrizeBox,
        [Info("Rare Prize Box")] RarePrizeBox,
        [Info("PRIZE_ID_Dream1")] PRIZE_ID_Dream1,
        [Info("PRIZE_ID_Dream2")] PRIZE_ID_Dream2,
        [Info("PRIZE_ID_Dream3")] PRIZE_ID_Dream3,
        [Info("PRIZE_ID_Dream4")] PRIZE_ID_Dream4,
        [Info("PRIZE_ID_Dream5")] PRIZE_ID_Dream5,
        [Info("PRIZE_ID_Dream6")] PRIZE_ID_Dream6,
        [Info("PRIZE_ID_Dream7")] PRIZE_ID_Dream7,
        [Info("PRIZE_ID_Dream8")] PRIZE_ID_Dream8,
        [Info("PRIZE_ID_Dream9")] PRIZE_ID_Dream9,
        [Info("PRIZE_ID_Dream10")] PRIZE_ID_Dream10,
        [Info("PRIZE_ID_Dream11")] PRIZE_ID_Dream11,
        [Info("PRIZE_ID_Dream12")] PRIZE_ID_Dream12,
        [Info("PRIZE_ID_Dream13")] PRIZE_ID_Dream13,
        [Info("PRIZE_ID_Dream14")] PRIZE_ID_Dream14,
        [Info("PRIZE_ID_Dream15")] PRIZE_ID_Dream15,
        [Info("PRIZE_ID_Dream16")] PRIZE_ID_Dream16,
        [Info("PRIZE_ID_Dream17")] PRIZE_ID_Dream17,
        [Info("PRIZE_ID_Dream18")] PRIZE_ID_Dream18,
        [Info("PRIZE_ID_Dream19")] PRIZE_ID_Dream19,
        [Info("PRIZE_ID_Dream20")] PRIZE_ID_Dream20,
        [Info("PRIZE_ID_Dream21")] PRIZE_ID_Dream21,
        [Info("PRIZE_ID_Dream22")] PRIZE_ID_Dream22,
        [Info("PRIZE_ID_Dream23")] PRIZE_ID_Dream23,
        [Info("PRIZE_ID_Dream24")] PRIZE_ID_Dream24,
        [Info("PRIZE_ID_Dream25")] PRIZE_ID_Dream25,
        [Info("PRIZE_ID_Dream26")] PRIZE_ID_Dream26,
        [Info("PRIZE_ID_Dream27")] PRIZE_ID_Dream27,
        [Info("PRIZE_ID_Dream28")] PRIZE_ID_Dream28,
        [Info("PRIZE_ID_Dream29")] PRIZE_ID_Dream29,
        [Info("PRIZE_ID_Dream30")] PRIZE_ID_Dream30,
        [Info("PRIZE_ID_Dream31")] PRIZE_ID_Dream31,
        [Info("PRIZE_ID_Dream32")] PRIZE_ID_Dream32,
        [Info("PRIZE_ID_Dream33")] PRIZE_ID_Dream33,
        [Info("PRIZE_ID_Dream34")] PRIZE_ID_Dream34,
        [Info("PRIZE_ID_Dream35")] PRIZE_ID_Dream35,
        [Info("PRIZE_ID_Dream36")] PRIZE_ID_Dream36,
        [Info("PRIZE_ID_Dream37")] PRIZE_ID_Dream37,
        //[Info("? ? ?")] ???,
        //[Info("? ? ?")] ???,
        //[Magic("Fire")] Fire,
        //[Magic("Fira")] Fira,
        //[Magic("Firaga")] Firaga,
        //[Magic("Dark Firaga")] DarkFiraga,
        //[Magic("Firaga Burst")] FiragaBurst,
        //[Magic("Mega Flare")] MegaFlare,
        //[Magic("Blizzard")] Blizzard,
        //[Magic("Blizzara")] Blizzara,
        //[Magic("Blizzaga")] Blizzaga,
        //[Magic("Icicle Splitter")] IcicleSplitter,
        //[Magic("Deep Freeze")] DeepFreeze,
        //[Magic("Ice Barrage")] IceBarrage,
        //[Magic("Thunder")] Thunder,
        //[Magic("Thundara")] Thundara,
        //[Magic("Thundaga")] Thundaga,
        //[Magic("Triple Plasma")] TriplePlasma,
        //[Magic("Cure")] Cure,
        //[Magic("Cura")] Cura,
        //[Magic("Curaga")] Curaga,
        //[Magic("Esuna")] Esuna,
        //[Magic("Zero Gravity")] ZeroGravity,
        //[Magic("Zero Gravira")] ZeroGravira,
        //[Magic("Zero Graviga")] ZeroGraviga,
        //[Magic("Zero Graviza")] ZeroGraviza,
        //[Magic("Balloon")] Balloon,
        //[Magic("Balloonra")] Balloonra,
        //[Magic("Balloonga")] Balloonga,
        //[Magic("Spark")] Spark,
        //[Magic("Sparkra")] Sparkra,
        //[Magic("Sparkga")] Sparkga,
        //[Magic("Faith")] Faith,
        //[Magic("Tornado")] Tornado,
        //[Magic("Meteor")] Meteor,
        //[Magic("Mini")] Mini,
        //[Magic("Blackout")] Blackout,
        //[Magic("Time Bomb")] TimeBomb,
        //[Magic("Confuse")] Confuse,
        //[Magic("Bind")] Bind,
        //[Magic("Poison")] Poison,
        //[Magic("Slow")] Slow,
        //[Magic("Sleep")] Sleep,
        //[Magic("Sleepra")] Sleepra,
        //[Magic("Sleepga")] Sleepga,
        //[Magic("Stop")] Stop,
        //[Magic("Vanish")] Vanish,
        //[Consumable("Potion")] Potion,
        //[Consumable("Hi-Potion")] HiPotion,
        //[Consumable("Mega-Potion")] MegaPotion,
        //[Consumable("Wakey Waker")] WakeyWaker,
        //[Consumable("Wakey Wham")] WakeyWham,
        //[Consumable("Panacea")] Panacea,
        //[Consumable("Elixir")] Elixir,
        //[Consumable("Megalixir")] Megalixir,
        //[Consumable("Dream Candy")] DreamCandy,
        //[Info("Protect")] Protect,
        //[Info("Shell")] Shell,
        //[Info("Regen")] Regen,
        //[Info("Haste")] Haste,
        //[Info("Drain")] Drain,
        //[Info("Combo Assist")] ComboAssist,
        //[Info("Auto-Life")] AutoLife,
        //[Info("Spirit Roar")] SpiritRoar,
        //[Info("Faith")] Faith,
        //[Info("Dark Mist")] DarkMist,
        //[Consumable("Elixir")] Elixir,
        //[Magic("Ice Zone")] IceZone,
        //[Magic("Thundaga")] Thundaga,
        //[Magic("Mega Flare")] MegaFlare,
        //[Magic("Waterga")] Waterga,
        //[Magic("Magnet Freeze")] MagnetFreeze,
        //[Magic("Laser Spin")] LaserSpin,
        //[Magic("Mega Flare")] MegaFlare,

        // xx02 - keyblades
        [Keyblade("Kingdom Key")] KingdomKey = ItemType.Keyblade,
        [Keyblade("Skull Noise (Sora)")] SkullNoiseS,
        [Keyblade("Guardian Bell (Sora)")] GuardianBellS,
        [Keyblade("Ferris Gear")] FerrisGear,
        [Keyblade("Dual Disc (Sora)")] DualDiscS,
        [Keyblade("All for One (Sora)")] AllForOneS,
        [Keyblade("Counterpoint (Sora)")] CounterpointS,
        [Keyblade("Sweet Dreams (Sora)")] SweetDreamsS,
        [Keyblade("Ultima Weapon (Sora)")] UltimaWeaponS,
        [Keyblade("Unbound (Sora)")] UnboundS,
        [Keyblade("Divewing (Sora)")] DiveWingS,
        [Keyblade("End of Pain (Sora)")] EndOfPainS,
        [Keyblade("Knockout Punch (Sora)")] KnockoutPunchS,
        [Keyblade("UNNAMED (RS-READY LARGE KEYBLADE ROSE HELP)")] UnnamedK1,
        [Keyblade("UNNAMED (RS-READY LARGE KEYBLADE ASSEMBLY HELP)")] UnnamedK2,
        [Keyblade("SORA UNUSED KBLADE (SORA UNUSED KEYBLADE 3 HELP)")] UnusedK1,
        [Keyblade("Soul Eater")] SoulEater,
        [Keyblade("Skull Noise (Riku)")] SkullNoiseR,
        [Keyblade("Guardian Bell (Riku)")] GuardianBellR,
        [Keyblade("Ocean's Rage")] OceansRage,
        [Keyblade("Dual Disc (Riku)")] DualDiscR,
        [Keyblade("All for One (Riku)")] AllForOneR,
        [Keyblade("Counterpoint (Riku)")] CounterpointR,
        [Keyblade("Sweet Dreams (Riku)")] SweetDreamsR,
        [Keyblade("Ultima Weapon (Riku)")] UltimaWeaponR,
        [Keyblade("Unbound (Riku)")] UnboundR,
        [Keyblade("Divewing (Riku)")] DiveWingR,
        [Keyblade("End of Pain (Riku)")] EndOfPainR,
        [Keyblade("Knockout Punch (Riku)")] KnockoutPunchR,
        [Keyblade("UNNAMED")] Unused1D02,
        [Keyblade("UNNAMED")] Unused1E02,
        [Keyblade("Way to the Dawn")] WayToTheDawn,

        [Recipe("Meow Wow Recipe")] MeowWowRecipe = ItemType.Recipe,
        [Recipe("Tama Sheep Recipe")] TamaSheepRecipe,
        [Recipe("Yoggy Ram Recipe")] YoggyRamRecipe,
        [Recipe("Komory Bat Recipe")] KomoryBatRecipe,
        [Recipe("Pricklemane Recipe")] PricklemaneRecipe,
        [Recipe("Hebby Repp Recipe")] HebbyReppRecipe,
        [Recipe("Sir Kyroo Recipe")] SirKyrooRecipe,
        [Recipe("Toximander Recipe")] ToximanderRecipe,
        [Recipe("Fin Fatale Recipe")] FinFataleRecipe,
        [Recipe("Tatsu Steed Recipe")] TatsuSteedRecipe,
        [Recipe("Necho Cat Recipe")] NechoCatRecipe,
        [Recipe("Thunderaffe Recipe")] ThunderaffeRecipe,
        [Recipe("Kooma Panda Recipe")] KoomaPandaRecipe,
        [Recipe("Pegaslick Recipe")] PegaslickRecipe,
        [Recipe("Iceguin Ace Recipe")] IceguinAceRecipe,
        [Recipe("Peepsta Hoo Recipe")] PeepstaHooRecipe,
        [Recipe("Escarglow Recipe")] EscarglowRecipe,
        [Recipe("KO Kabuto Recipe")] KOKabutoRecipe,
        [Recipe("Wheeflower Recipe")] WheeflowerRecipe,
        [Recipe("Ghostabocky Recipe")] GhostabockyRecipe,
        [Recipe("Zolephant Recipe")] ZolephantRecipe,
        [Recipe("Juggle Pup Recipe")] JugglePupRecipe,
        [Recipe("Halbird Recipe")] HalbirdRecipe,
        [Recipe("Staggerceps Recipe")] StaggercepsRecipe,
        [Recipe("Fishbon")] Fishbon,
        [Recipe("Unused Recipe")] UnusedRecipe,
        [Recipe("Flowbermeow Recipe")] FlowbermeowRecipe,
        [Recipe("Cyber Yog Recipe")] CyberYogRecipe,
        [Recipe("Chef Kyroo Recipe")] ChefKyrooRecipe,
        [Recipe("Lord Kyroo Recipe")] LordKyrooRecipe,
        [Recipe("Tatsu Blaze Recipe")] TatsuBlazeRecipe,
        [Recipe("Electricorn Recipe")] ElectricornRecipe,
        [Recipe("Woeflower Recipe")] WoeflowerRecipe,
        [Recipe("Jestabocky Recipe")] JestabockyRecipe,
        [Recipe("Eaglider Recipe")] EagliderRecipe,
        [Recipe("Me Me Bunny Recipe")] MeMeBunnyRecipe,
        [Recipe("Drill Sye Recipe")] DrillSyeRecipe,
        [Recipe("Tyranto Rex Recipe")] TyrantoRexRecipe,
        [Recipe("Majik Lapin Recipe")] MajikLapinRecipe,
        [Recipe("Cera Terror Recipe")] CeraTerrorRecipe,
        [Recipe("Skelterwild Recipe")] SkelterwildRecipe,
        [Recipe("Ducky Goose Recipe")] DuckyGooseRecipe,
        [Recipe("Aura Lion Recipe")] AuraLionRecipe,
        [Recipe("Ryu Dragon Recipe")] RyuDragonRecipe,
        [Recipe("Drak Quack Recipe")] DrakQuackRecipe,
        [Recipe("Keeba Tiger Recipe")] KeebaTigerRecipe,
        [Recipe("Meowjesty Recipe")] MeowjestyRecipe,
        [Recipe("Sudo Neku Recipe")] SudoNekuRecipe,
        [Recipe("Frootz Cat Recipe")] FrootzCatRecipe,
        [Recipe("Ursa Circus Recipe")] UrsaCircusRecipe,
        [Recipe("Kab Kannon Recipe")] KabKannonRecipe,
        [Recipe("R & R Seal Recipe")] RAndRSealRecipe,
        [Recipe("Catanuki Recipe")] CatanukiRecipe,
        [Recipe("Beatalike Recipe")] BeatalikeRecipe,
        [Recipe("Tubguin Ace Recipe")] TubguinAceRecipe,
        [Recipe("RECIPE 55")] RECIPE_55,
        [Recipe("RECIPE 56")] RECIPE_56,
        [Recipe("RECIPE 57")] RECIPE_57,
        [Recipe("RECIPE 58")] RECIPE_58,
        [Recipe("RECIPE 59")] RECIPE_59,
        [Recipe("RECIPE 60")] RECIPE_60,

        [KeyItem("Stage Gadget")] StageGadget = ItemType.KeyItem,
        [KeyItem("KEY ITEM 2")] KEY_ITEM_2,
        [KeyItem("KEY ITEM 3")] KEY_ITEM_3,
        [KeyItem("KEY ITEM 4")] KEY_ITEM_4,
        [KeyItem("KEY ITEM 5")] KEY_ITEM_5,
        [KeyItem("KEY ITEM 6")] KEY_ITEM_6,
        [KeyItem("KEY ITEM 7")] KEY_ITEM_7,
        [KeyItem("KEY ITEM 8")] KEY_ITEM_8,
        [KeyItem("KEY ITEM 9")] KEY_ITEM_9,
        [KeyItem("KEY ITEM 10")] KEY_ITEM_10,
        [KeyItem("KEY ITEM 11")] KEY_ITEM_11,
        [KeyItem("KEY ITEM 12")] KEY_ITEM_12,
        [KeyItem("KEY ITEM 13")] KEY_ITEM_13,
        [KeyItem("KEY ITEM 14")] KEY_ITEM_14,
        [KeyItem("KEY ITEM 15")] KEY_ITEM_15,
        [KeyItem("KEY ITEM 16")] KEY_ITEM_16,
        [KeyItem("KEY ITEM 17")] KEY_ITEM_17,
        [KeyItem("KEY ITEM 18")] KEY_ITEM_18,
        [KeyItem("KEY ITEM 19")] KEY_ITEM_19,
        [KeyItem("KEY ITEM 20")] KEY_ITEM_20,
        [KeyItem("KEY ITEM 21")] KEY_ITEM_21,
        [KeyItem("KEY ITEM 22")] KEY_ITEM_22,
        [KeyItem("KEY ITEM 23")] KEY_ITEM_23,
        [KeyItem("KEY ITEM 24")] KEY_ITEM_24,
        [KeyItem("KEY ITEM 25")] KEY_ITEM_25,
        [KeyItem("KEY ITEM 26")] KEY_ITEM_26,
        [KeyItem("KEY ITEM 27")] KEY_ITEM_27,
        [KeyItem("KEY ITEM 28")] KEY_ITEM_28,
        [KeyItem("KEY ITEM 29")] KEY_ITEM_29,
        [KeyItem("KEY ITEM 30")] KEY_ITEM_30,
        [KeyItem("KEY ITEM 31")] KEY_ITEM_31,
        [KeyItem("KEY ITEM 32")] KEY_ITEM_32,
        [KeyItem("KEY ITEM 33")] KEY_ITEM_33,
        [KeyItem("KEY ITEM 34")] KEY_ITEM_34,
        [KeyItem("KEY ITEM 35")] KEY_ITEM_35,
        [KeyItem("KEY ITEM 36")] KEY_ITEM_36,
        [KeyItem("KEY ITEM 37")] KEY_ITEM_37,
        [KeyItem("KEY ITEM 38")] KEY_ITEM_38,
        [KeyItem("KEY ITEM 39")] KEY_ITEM_39,
        [KeyItem("KEY ITEM 40")] KEY_ITEM_40,

        [Glossary("Keyblades")] Keyblades = ItemType.Glossary,
        [Glossary("Keyblade Masters")] KeybladeMasters,
        [Glossary("Master Xehanort")] MasterXehanort,
        [Glossary("The Keyblade War")] TheKeybladeWar,
        [Glossary("Heartless")] Heartless,
        [Glossary("Kingdom Hearts")] KingdomHearts,
        [Glossary("Nobodies")] Nobodies,
        [Glossary("Organization ")] Organization,
        [Glossary("Seven Princesses")] SevenPrincesses,
        [Glossary("Recusant's Sigil")] RecusantSigil,
        [Glossary("χ-blade")] XBlade,
        [Glossary("Hearts Tied to Sora")] HeartsTiedtoSora,
        [Glossary("Secret Message")] SecretMessage,
        [Glossary("GLOSSARY 14")] GLOSSARY_14,
        [Glossary("GLOSSARY 15")] GLOSSARY_15,
        [Glossary("GLOSSARY 16")] GLOSSARY_16,
        [Glossary("GLOSSARY 17")] GLOSSARY_17,
        [Glossary("GLOSSARY 18")] GLOSSARY_18,
        [Glossary("GLOSSARY 19")] GLOSSARY_19,
        [Glossary("GLOSSARY 20")] GLOSSARY_20,

        [DreamPieces("Fleeting Figment")] FleetingFigment = ItemType.DreamPiece,
        [DreamPieces("Fleeting Fancy")] FleetingFancy,
        [DreamPieces("Fleeting Fantasy")] FleetingFantasy,
        [DreamPieces("Lofty Figment")] LoftyFigment,
        [DreamPieces("Lofty Fancy")] LoftyFancy,
        [DreamPieces("Lofty Fantasy")] LoftyFantasy,
        [DreamPieces("Rampant Figment")] RampantFigment,
        [DreamPieces("Rampant Fancy")] RampantFancy,
        [DreamPieces("Rampant Fantasy")] RampantFantasy,
        [DreamPieces("Dulcet Figment")] DulcetFigment,
        [DreamPieces("Dulcet Fancy")] DulcetFancy,
        [DreamPieces("Dulcet Fantasy")] DulcetFantasy,
        [DreamPieces("Malleable Fantasy")] MalleableFantasy,
        [DreamPieces("Prickly Fantasy")] PricklyFantasy,
        [DreamPieces("Wild Fantasy")] WildFantasy,
        [DreamPieces("Epic Fantasy")] EpicFantasy,
        [DreamPieces("Charming Fantasy")] CharmingFantasy,
        [DreamPieces("Brilliant Fantasy")] BrilliantFantasy,
        [DreamPieces("Intrepid Figment")] IntrepidFigment,
        [DreamPieces("Intrepid Fancy")] IntrepidFancy,
        [DreamPieces("Intrepid Fantasy")] IntrepidFantasy,
        [DreamPieces("Savage Fantasy")] SavageFantasy,
        [DreamPieces("Noble Figment")] NobleFigment,
        [DreamPieces("Noble Fancy")] NobleFancy,
        [DreamPieces("Noble Fantasy")] NobleFantasy,
        [DreamPieces("Grim Figment")] GrimFigment,
        [DreamPieces("Grim Fancy")] GrimFancy,
        [DreamPieces("Grim Fantasy")] GrimFantasy,
        [DreamPieces("Vibrant Figment")] VibrantFigment,
        [DreamPieces("Vibrant Fancy")] VibrantFancy,
        [DreamPieces("Vibrant Fantasy")] VibrantFantasy,
        [DreamPieces("Troubling Figment")] TroublingFigment,
        [DreamPieces("Troubling Fancy")] TroublingFancy,
        [DreamPieces("Troubling Fantasy")] TroublingFantasy,
        [DreamPieces("Wondrous Figment")] WondrousFigment,
        [DreamPieces("Wondrous Fancy")] WondrousFancy,
        [DreamPieces("Wondrous Fantasy")] WondrousFantasy,

        [TrainingFood("Confetti Candy")] ConfettiCandy = ItemType.TrainingFood,
        [TrainingFood("Shield Cookie")] ShieldCookie,
        [TrainingFood("Block-It Chocolate")] BlockItChocolate,
        [TrainingFood("Ice Dream Cone")] IceDreamCone,
        [TrainingFood("Royal Cake")] RoyalCake,
        [TrainingFood("Confetti Candy 2")] ConfettiCandy2,
        [TrainingFood("Shield Cookie 2")] ShieldCookie2,
        [TrainingFood("Block-It Chocolate 2")] BlockItChocolate2,
        [TrainingFood("Ice Dream Cone 2")] IceDreamCone2,
        [TrainingFood("Confetti Candy 3")] ConfettiCandy3,
        [TrainingFood("Shield Cookie 3")] ShieldCookie3,
        [TrainingFood("Block-It Chocolate 3")] BlockItChocolate3,
        [TrainingFood("Ice Dream Cone 3")] IceDreamCone3,
        [TrainingFood("FOOD ITEM 16")] FOOD_ITEM_16,
        [TrainingFood("FOOD ITEM 17")] FOOD_ITEM_17,
        [TrainingFood("FOOD ITEM 18")] FOOD_ITEM_18,
        [TrainingFood("FOOD ITEM 19")] FOOD_ITEM_19,
        [TrainingFood("FOOD ITEM 20")] FOOD_ITEM_20,

        [TrainingToys("Balloon")] BalloonToy = ItemType.TrainingToy,
        [TrainingToys("Candy Goggles")] CandyGoggles,
        [TrainingToys("Water Barrel")] WaterBarrel,
        [TrainingToys("Paint Gun: Red")] PaintGun_Red,
        [TrainingToys("Paint Gun: Blue")] PaintGun_Blue,
        [TrainingToys("Paint Gun: Green")] PaintGun_Green,
        [TrainingToys("Paint Gun: Yellow")] PaintGun_Yellow,
        [TrainingToys("Paint Gun: White")] PaintGun_White,
        [TrainingToys("Paint Gun: Black")] PaintGun_Black,
        [TrainingToys("Paint Gun: Purple")] PaintGun_Purple,
        [TrainingToys("Paint Gun: Sky Blue")] PaintGun_SkyBlue,
        [TrainingToys("TOY 14")] TOY_14,
        [TrainingToys("TOY 15")] TOY_15,
        [TrainingToys("TOY 16")] TOY_16,
        [TrainingToys("TOY 17")] TOY_17,
        [TrainingToys("TOY 18")] TOY_18,
        [TrainingToys("TOY 19")] TOY_19,
        [TrainingToys("TOY 20")] TOY_20,

        // xx09 - Memento Entries
    }
}
