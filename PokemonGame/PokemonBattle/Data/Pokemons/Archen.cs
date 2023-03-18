using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Archen : Pokemon
	{
		public override string Name => "Archen";
		public override List<Ability> AvailableAbilities => new() {new Defeatist() };
		public override Stats BaseStats => new Stats(55, 112, 45, 74, 45, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Leer() },
			[3] = new List<Move>() { new Rockthrow() },
			[6] = new List<Move>() { new Wingattack() },
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
			[39] = new List<Move>() { new Dragonclaw() },
			[42] = new List<Move>() { new Thrash() },
			[45] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Allyswitch(), new Assurance(), new Attract(), new Bounce(), new Bulldoze(), new Crunch(), new Dig(), new Dragonclaw(), new Dragonpulse(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Heatwave(), new Hiddenpower(), new Irondefense(), new Irontail(), new Lashout(), new Meteorbeam(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelwing(), new Stoneedge(), new Substitute(), new Swift(), new Taunt(), new Uproar(), new Uturn(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Bite(), new Defog(), new Doubleteam(), new Headsmash(), new Knockoff(), new Switcheroo() };
		public override int Weight => 95;
		public override int ExpYield => 71;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}