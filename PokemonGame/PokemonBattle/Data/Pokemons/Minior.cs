using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Minior : Pokemon
	{
		public override string Name => "Minior";
		public override List<Ability> AvailableAbilities => new() {new Shieldsdown() };
		public override Stats BaseStats => new Stats(60, 60, 100, 60, 100, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[3] = new List<Move>() { new Defensecurl() },
			[8] = new List<Move>() { new Rollout() },
			[10] = new List<Move>() { new Confuseray() },
			[15] = new List<Move>() { new Swift() },
			[17] = new List<Move>() { new Ancientpower() },
			[22] = new List<Move>() { new Selfdestruct() },
			[24] = new List<Move>() { new Stealthrock() },
			[29] = new List<Move>() { new Takedown() },
			[31] = new List<Move>() { new Autotomize() },
			[36] = new List<Move>() { new Cosmicpower() },
			[38] = new List<Move>() { new Powergem() },
			[43] = new List<Move>() { new Doubleedge() },
			[45] = new List<Move>() { new Shellsmash() },
			[50] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Earthquake(), new Endeavor(), new Explosion(), new Facade(), new Frustration(), new Gigaimpact(), new Gravity(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Lastresort(), new Lightscreen(), new Magnetrise(), new Protect(), new Psychic(), new Psychup(), new Reflect(), new Rest(), new Return(), new Rockpolish(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Stoneedge(), new Substitute(), new Swagger(), new Telekinesis(), new Toxic(), new Uturn(), new Zenheadbutt() };
		public override int Weight => 400;
		public override int ExpYield => 154;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}