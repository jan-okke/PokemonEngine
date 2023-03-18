using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ribombee : Pokemon
	{
		public override string Name => "Ribombee";
		public override List<Ability> AvailableAbilities => new() {new Honeygather(), new Shielddust() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sweetveil() };
		public override Stats BaseStats => new Stats(60, 55, 60, 95, 70, 124);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Pollenpuff() },
			[1] = new List<Move>() { new Pollenpuff(), new Covet(), new Absorb(), new Fairywind(), new Stunspore(), new Sweetscent() },
			[18] = new List<Move>() { new Drainingkiss() },
			[24] = new List<Move>() { new Strugglebug() },
			[32] = new List<Move>() { new Aromatherapy() },
			[40] = new List<Move>() { new Switcheroo() },
			[48] = new List<Move>() { new Dazzlinggleam() },
			[56] = new List<Move>() { new Bugbuzz() },
			[64] = new List<Move>() { new Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Allyswitch(), new Attract(), new Batonpass(), new Bugbuzz(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Dualwingbeat(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Leechlife(), new Lightscreen(), new Magicalleaf(), new Magicroom(), new Playrough(), new Pollenpuff(), new Protect(), new Psychic(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Speedswap(), new Substitute(), new Sunnyday(), new Swift(), new Thief(), new Trick(), new Uturn(), new Wonderroom() };
		public override int Weight => 5;
		public override int ExpYield => 162;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}