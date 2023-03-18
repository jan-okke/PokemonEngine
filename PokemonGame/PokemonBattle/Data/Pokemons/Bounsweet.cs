using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bounsweet : Pokemon
	{
		public override string Name => "Bounsweet";
		public override List<Ability> AvailableAbilities => new() {new Leafguard(), new Oblivious() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sweetveil() };
		public override Stats BaseStats => new Stats(42, 30, 38, 32, 30, 38);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash() },
			[4] = new List<Move>() { new Playnice() },
			[8] = new List<Move>() { new Rapidspin() },
			[12] = new List<Move>() { new Razorleaf() },
			[16] = new List<Move>() { new Sweetscent() },
			[20] = new List<Move>() { new Magicalleaf() },
			[24] = new List<Move>() { new Flail() },
			[28] = new List<Move>() { new Teeterdance() },
			[32] = new List<Move>() { new Aromaticmist() },
			[36] = new List<Move>() { new Aromatherapy() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Helpinghand(), new Hiddenpower(), new Lightscreen(), new Magicalleaf(), new Playrough(), new Protect(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Acupressure(), new Endeavor(), new Synthesis() };
		public override int Weight => 32;
		public override int ExpYield => 42;
		public override int CatchRate => 235;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}