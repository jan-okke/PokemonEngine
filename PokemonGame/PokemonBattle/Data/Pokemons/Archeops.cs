using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Archeops : Pokemon
	{
		public override string Name => "Archeops";
		public override List<Ability> AvailableAbilities => new() {new Defeatist() };
		public override Stats BaseStats => new Stats(75, 140, 65, 110, 112, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Leer(), new Rockthrow(), new Wingattack() },
			[9] = new List<Move>() { new Dragonbreath() },
			[12] = new List<Move>() { new Ancientpower() },
			[15] = new List<Move>() { new Pluck() },
			[18] = new List<Move>() { new Quickguard() },
			[21] = new List<Move>() { new Uturn() },
			[24] = new List<Move>() { new Rockslide() },
			[27] = new List<Move>() { new Scaryface() },
			[30] = new List<Move>() { new Crunch() },
			[33] = new List<Move>() { new Agility() },
			[36] = new List<Move>() { new Tailwind() },
			[41] = new List<Move>() { new Dragonclaw() },
			[46] = new List<Move>() { new Thrash() },
			[51] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Airslash(), new Allyswitch(), new Assurance(), new Attract(), new Bounce(), new Bulldoze(), new Crunch(), new Dig(), new Dragonclaw(), new Dragonpulse(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fly(), new Focusblast(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Irontail(), new Lashout(), new Meteorbeam(), new Outrage(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelwing(), new Stoneedge(), new Substitute(), new Swift(), new Taunt(), new Uproar(), new Uturn(), new Zenheadbutt() };
		public override int Weight => 320;
		public override int ExpYield => 177;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}