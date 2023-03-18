using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vivillon : Pokemon
	{
		public override string Name => "Vivillon";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Shielddust(), new Abilities.Compoundeyes() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Friendguard() };
		public override Stats BaseStats => new Stats(80, 52, 50, 90, 50, 89);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Gust() },
			[1] = new List<Move>() { new Moves.Gust(), new Moves.Powder(), new Moves.Sleeppowder(), new Moves.Poisonpowder(), new Moves.Stunspore(), new Moves.Strugglebug() },
			[12] = new List<Move>() { new Moves.Lightscreen() },
			[17] = new List<Move>() { new Moves.Psybeam() },
			[21] = new List<Move>() { new Moves.Supersonic() },
			[25] = new List<Move>() { new Moves.Drainingkiss() },
			[31] = new List<Move>() { new Moves.Aromatherapy() },
			[35] = new List<Move>() { new Moves.Bugbuzz() },
			[41] = new List<Move>() { new Moves.Safeguard() },
			[45] = new List<Move>() { new Moves.Quiverdance() },
			[50] = new List<Move>() { new Moves.Hurricane() },
			[55] = new List<Move>() { new Moves.Powder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Bugbite(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Electroweb(), new Moves.Endeavor(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Laserfocus(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Toxic(), new Moves.Uturn() };
		public override int Weight => 170;
		public override int ExpYield => 206;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}