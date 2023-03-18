using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Stantler : Pokemon
	{
		public override string Name => "Stantler";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Frisk() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sapsipper() };
		public override Stats BaseStats => new Stats(73, 95, 62, 85, 65, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[3] = new List<Move>() { new Leer() },
			[7] = new List<Move>() { new Astonish() },
			[10] = new List<Move>() { new Hypnosis() },
			[13] = new List<Move>() { new Stomp() },
			[16] = new List<Move>() { new Sandattack() },
			[21] = new List<Move>() { new Takedown() },
			[23] = new List<Move>() { new Confuseray() },
			[27] = new List<Move>() { new Calmmind() },
			[33] = new List<Move>() { new Roleplay() },
			[38] = new List<Move>() { new Zenheadbutt() },
			[43] = new List<Move>() { new Lunge() },
			[49] = new List<Move>() { new Imprison() },
			[50] = new List<Move>() { new Entrainment() },
			[55] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Confide(), new Doubleteam(), new Dreameater(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigaimpact(), new Gravity(), new Hiddenpower(), new Irontail(), new Lastresort(), new Lightscreen(), new Magicroom(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Return(), new Roar(), new Roleplay(), new Round(), new Shadowball(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Spite(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trickroom(), new Uproar(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Bite(), new Disable(), new Doublekick(), new Extrasensory(), new Megahorn(), new Spite(), new Thrash(), new Zenheadbutt() };
		public override int Weight => 712;
		public override int ExpYield => 163;
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