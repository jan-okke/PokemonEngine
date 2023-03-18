using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hatenna : Pokemon
	{
		public override string Name => "Hatenna";
		public override List<Ability> AvailableAbilities => new() {new Healer(), new Anticipation() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicbounce() };
		public override Stats BaseStats => new Stats(42, 30, 45, 56, 53, 39);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confusion(), new Playnice() },
			[5] = new List<Move>() { new Lifedew() },
			[10] = new List<Move>() { new Disarmingvoice() },
			[15] = new List<Move>() { new Aromatherapy() },
			[20] = new List<Move>() { new Psybeam() },
			[25] = new List<Move>() { new Healpulse() },
			[30] = new List<Move>() { new Dazzlinggleam() },
			[35] = new List<Move>() { new Calmmind() },
			[40] = new List<Move>() { new Psychic() },
			[45] = new List<Move>() { new Healingwish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Calmmind(), new Charm(), new Darkpulse(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Expandingforce(), new Facade(), new Gigadrain(), new Helpinghand(), new Hiddenpower(), new Imprison(), new Lightscreen(), new Magicalleaf(), new Mysticalfire(), new Playrough(), new Protect(), new Psychic(), new Psyshock(), new Rest(), new Round(), new Safeguard(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Thunderwave() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Aromaticmist(), new Nuzzle(), new Quash() };
		public override int Weight => 34;
		public override int ExpYield => 53;
		public override int CatchRate => 235;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}