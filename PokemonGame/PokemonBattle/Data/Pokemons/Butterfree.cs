using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Butterfree : Pokemon
	{
		public override string Name => "Butterfree";
		public override List<Ability> AvailableAbilities => new() {new Compoundeyes() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Tintedlens() };
		public override Stats BaseStats => new Stats(60, 45, 50, 90, 80, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Gust() },
			[1] = new List<Move>() { new Gust(), new Harden(), new Tackle(), new Stringshot(), new Bugbite() },
			[4] = new List<Move>() { new Supersonic() },
			[8] = new List<Move>() { new Confusion() },
			[12] = new List<Move>() { new Poisonpowder(), new Stunspore(), new Sleeppowder() },
			[16] = new List<Move>() { new Psybeam() },
			[20] = new List<Move>() { new Whirlwind() },
			[24] = new List<Move>() { new Airslash() },
			[28] = new List<Move>() { new Safeguard() },
			[32] = new List<Move>() { new Bugbuzz() },
			[36] = new List<Move>() { new Tailwind() },
			[40] = new List<Move>() { new Ragepowder() },
			[44] = new List<Move>() { new Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Airslash(), new Attract(), new Batonpass(), new Bugbuzz(), new Defog(), new Doubleteam(), new Drainingkiss(), new Dreameater(), new Dualwingbeat(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Irondefense(), new Pollenpuff(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Roost(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Uturn(), new Venoshock() };
		public override int Weight => 320;
		public override int ExpYield => 198;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}