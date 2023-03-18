using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Indeedee : Pokemon
	{
		public override string Name => "Indeedee";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus(), new Synchronize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Psychicsurge() };
		public override Stats BaseStats => new Stats(60, 65, 55, 105, 95, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Storedpower(), new Playnice() },
			[5] = new List<Move>() { new Encore() },
			[10] = new List<Move>() { new Disarmingvoice() },
			[15] = new List<Move>() { new Psybeam() },
			[20] = new List<Move>() { new Helpinghand() },
			[25] = new List<Move>() { new Afteryou() },
			[30] = new List<Move>() { new Aromatherapy() },
			[35] = new List<Move>() { new Psychic() },
			[40] = new List<Move>() { new Calmmind() },
			[45] = new List<Move>() { new Powersplit() },
			[50] = new List<Move>() { new Psychicterrain() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Dazzlinggleam(), new Drainingkiss(), new Drainpunch(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Futuresight(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Imprison(), new Magicalleaf(), new Magicroom(), new Metronome(), new Mysticalfire(), new Payday(), new Playrough(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Rest(), new Round(), new Shadowball(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Swift(), new Terrainpulse(), new Triattack(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Extrasensory(), new Fakeout(), new Psychup() };
		public override int Weight => 280;
		public override int ExpYield => 166;
		public override int CatchRate => 30;
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