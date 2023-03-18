using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cutiefly : Pokemon
	{
		public override string Name => "Cutiefly";
		public override List<Ability> AvailableAbilities => new() {new Honeygather(), new Shielddust() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sweetveil() };
		public override Stats BaseStats => new Stats(40, 45, 40, 55, 40, 84);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Fairywind() },
			[6] = new List<Move>() { new Stunspore() },
			[12] = new List<Move>() { new Sweetscent() },
			[18] = new List<Move>() { new Drainingkiss() },
			[24] = new List<Move>() { new Strugglebug() },
			[30] = new List<Move>() { new Aromatherapy() },
			[36] = new List<Move>() { new Switcheroo() },
			[42] = new List<Move>() { new Dazzlinggleam() },
			[48] = new List<Move>() { new Bugbuzz() },
			[54] = new List<Move>() { new Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Allyswitch(), new Attract(), new Batonpass(), new Bugbuzz(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Dualwingbeat(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Helpinghand(), new Hiddenpower(), new Imprison(), new Leechlife(), new Lightscreen(), new Magicroom(), new Playrough(), new Protect(), new Psychic(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Skillswap(), new Sleeptalk(), new Snore(), new Speedswap(), new Substitute(), new Sunnyday(), new Swift(), new Thief(), new Trick(), new Uturn(), new Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Aromaticmist(), new Moonblast(), new Stickyweb() };
		public override int Weight => 2;
		public override int ExpYield => 61;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}