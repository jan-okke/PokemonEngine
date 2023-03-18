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
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stormdrain() };
		public override Stats BaseStats => new Stats(75, 86, 67, 106, 67, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Spikyshield(), new Peck(), new Absorb(), new Afteryou(), new Ingrain() },
			[4] = new List<Move>() { new Growth() },
			[8] = new List<Move>() { new Megadrain() },
			[12] = new List<Move>() { new Leechseed() },
			[16] = new List<Move>() { new Suckerpunch() },
			[20] = new List<Move>() { new Pinmissile() },
			[24] = new List<Move>() { new Gigadrain() },
			[28] = new List<Move>() { new Sweetscent() },
			[32] = new List<Move>() { new Synthesis() },
			[36] = new List<Move>() { new Petalblizzard() },
			[40] = new List<Move>() { new Cottonspore() },
			[44] = new List<Move>() { new Sunnyday() },
			[48] = new List<Move>() { new Solarbeam() },
			[52] = new List<Move>() { new Acupressure() },
			[56] = new List<Move>() { new Petaldance() },
			[60] = new List<Move>() { new Cottonguard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bounce(), new Bulletseed(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Leafstorm(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Screech(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Spikes(), new Substitute(), new Sunnyday(), new Throatchop(), new Uproar(), new Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Woodhammer(), new Worryseed() };
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