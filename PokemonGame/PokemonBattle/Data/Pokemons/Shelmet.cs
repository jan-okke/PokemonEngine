using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shelmet : Pokemon
	{
		public override string Name => "Shelmet";
		public override List<Ability> AvailableAbilities => new() {new Hydration(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(50, 40, 85, 40, 65, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Protect() },
			[4] = new List<Move>() { new Acid() },
			[8] = new List<Move>() { new Curse() },
			[12] = new List<Move>() { new Megadrain() },
			[16] = new List<Move>() { new Strugglebug() },
			[20] = new List<Move>() { new Yawn() },
			[24] = new List<Move>() { new Acidarmor() },
			[28] = new List<Move>() { new Gigadrain() },
			[32] = new List<Move>() { new Guardswap() },
			[36] = new List<Move>() { new Bodyslam() },
			[40] = new List<Move>() { new Recover() },
			[44] = new List<Move>() { new Bugbuzz() },
			[48] = new List<Move>() { new Finalgambit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bodyslam(), new Bugbuzz(), new Encore(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Guardswap(), new Hiddenpower(), new Leechlife(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Round(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Spikes(), new Substitute(), new Toxicspikes(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Doubleedge(), new Feint(), new Guardsplit(), new Mindreader() };
		public override int Weight => 77;
		public override int ExpYield => 61;
		public override int CatchRate => 200;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}