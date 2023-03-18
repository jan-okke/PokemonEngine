using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wormadam : Pokemon
	{
		public override string Name => "Wormadam";
		public override List<Ability> AvailableAbilities => new() {new Anticipation() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(60, 59, 85, 36, 79, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Quiverdance() },
			[1] = new List<Move>() { new Quiverdance(), new Suckerpunch(), new Tackle(), new Protect(), new Bugbite() },
			[10] = new List<Move>() { new Protect() },
			[15] = new List<Move>() { new Bugbite() },
			[20] = new List<Move>() { new Stringshot() },
			[23] = new List<Move>() { new Confusion() },
			[26] = new List<Move>() { new Razorleaf() },
			[29] = new List<Move>() { new Growth() },
			[32] = new List<Move>() { new Psybeam() },
			[35] = new List<Move>() { new Infestation() },
			[38] = new List<Move>() { new Flail() },
			[41] = new List<Move>() { new Attract() },
			[44] = new List<Move>() { new Psychic() },
			[47] = new List<Move>() { new Leafstorm() },
			[50] = new List<Move>() { new Bugbuzz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bugbite(), new Bugbuzz(), new Bulletseed(), new Confide(), new Dig(), new Doubleteam(), new Dreameater(), new Electroweb(), new Endeavor(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Shadowball(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Telekinesis(), new Thief(), new Uproar(), new Venoshock(), new Worryseed() };
		public override int Weight => 65;
		public override int ExpYield => 148;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}