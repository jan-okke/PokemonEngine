using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arceus : Pokemon
	{
		public override string Name => "Arceus";
		public override List<Ability> AvailableAbilities => new() {new Multitype() };
		public override Stats BaseStats => new Stats(120, 120, 120, 120, 120, 120);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Seismictoss(), new Cosmicpower() },
			[10] = new List<Move>() { new Gravity() },
			[20] = new List<Move>() { new Earthpower() },
			[30] = new List<Move>() { new Hypervoice() },
			[40] = new List<Move>() { new Extremespeed() },
			[50] = new List<Move>() { new Healingwish() },
			[60] = new List<Move>() { new Futuresight() },
			[70] = new List<Move>() { new Recover() },
			[80] = new List<Move>() { new Hyperbeam() },
			[90] = new List<Move>() { new Perishsong() },
			[100] = new List<Move>() { new Judgment() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aquatail(), new Avalanche(), new Blizzard(), new Brickbreak(), new Brine(), new Bulldoze(), new Bulletseed(), new Calmmind(), new Chargebeam(), new Confide(), new Cut(), new Darkpulse(), new Defog(), new Dive(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Dreameater(), new Earthpower(), new Earthquake(), new Echoedvoice(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Flamethrower(), new Flash(), new Flashcannon(), new Fly(), new Focusblast(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Gravity(), new Hail(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Irondefense(), new Ironhead(), new Irontail(), new Laserfocus(), new Lastresort(), new Lightscreen(), new Liquidation(), new Magiccoat(), new Outrage(), new Overheat(), new Payback(), new Poisonjab(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Quash(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Solarbeam(), new Stealthrock(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swordsdance(), new Tailwind(), new Telekinesis(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Trickroom(), new Waterfall(), new Waterpulse(), new Willowisp(), new Workup(), new Xscissor(), new Zenheadbutt() };
		public override int Weight => 3200;
		public override int ExpYield => 360;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}