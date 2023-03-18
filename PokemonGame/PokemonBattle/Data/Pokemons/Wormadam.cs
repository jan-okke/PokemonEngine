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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Anticipation() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
		public override Stats BaseStats => new Stats(60, 59, 85, 79, 105, 36);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Quiverdance() },
			[1] = new List<Move>() { new Moves.Quiverdance(), new Moves.Suckerpunch(), new Moves.Tackle(), new Moves.Protect(), new Moves.Bugbite() },
			[10] = new List<Move>() { new Moves.Protect() },
			[15] = new List<Move>() { new Moves.Bugbite() },
			[20] = new List<Move>() { new Moves.Stringshot() },
			[23] = new List<Move>() { new Moves.Confusion() },
			[26] = new List<Move>() { new Moves.Razorleaf() },
			[29] = new List<Move>() { new Moves.Growth() },
			[32] = new List<Move>() { new Moves.Psybeam() },
			[35] = new List<Move>() { new Moves.Infestation() },
			[38] = new List<Move>() { new Moves.Flail() },
			[41] = new List<Move>() { new Moves.Attract() },
			[44] = new List<Move>() { new Moves.Psychic() },
			[47] = new List<Move>() { new Moves.Leafstorm() },
			[50] = new List<Move>() { new Moves.Bugbuzz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Electroweb(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Uproar(), new Moves.Venoshock(), new Moves.Worryseed() };
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