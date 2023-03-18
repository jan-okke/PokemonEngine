using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Maractus : Pokemon
	{
		public override string Name => "Maractus";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb(), new Abilities.Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Stormdrain() };
		public override Stats BaseStats => new Stats(75, 86, 67, 106, 67, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Spikyshield(), new Moves.Peck(), new Moves.Absorb(), new Moves.Afteryou(), new Moves.Ingrain() },
			[4] = new List<Move>() { new Moves.Growth() },
			[8] = new List<Move>() { new Moves.Megadrain() },
			[12] = new List<Move>() { new Moves.Leechseed() },
			[16] = new List<Move>() { new Moves.Suckerpunch() },
			[20] = new List<Move>() { new Moves.Pinmissile() },
			[24] = new List<Move>() { new Moves.Gigadrain() },
			[28] = new List<Move>() { new Moves.Sweetscent() },
			[32] = new List<Move>() { new Moves.Synthesis() },
			[36] = new List<Move>() { new Moves.Petalblizzard() },
			[40] = new List<Move>() { new Moves.Cottonspore() },
			[44] = new List<Move>() { new Moves.Sunnyday() },
			[48] = new List<Move>() { new Moves.Solarbeam() },
			[52] = new List<Move>() { new Moves.Acupressure() },
			[56] = new List<Move>() { new Moves.Petaldance() },
			[60] = new List<Move>() { new Moves.Cottonguard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bounce(), new Moves.Bulletseed(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Leafstorm(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Throatchop(), new Moves.Uproar(), new Moves.Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Woodhammer(), new Moves.Worryseed() };
		public override int Weight => 280;
		public override int ExpYield => 161;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}