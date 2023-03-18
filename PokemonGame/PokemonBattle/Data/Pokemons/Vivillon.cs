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
		public override List<Ability> AvailableAbilities => new() {new Shielddust(), new Compoundeyes() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Friendguard() };
		public override Stats BaseStats => new Stats(80, 52, 50, 89, 90, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Gust() },
			[1] = new List<Move>() { new Gust(), new Powder(), new Sleeppowder(), new Poisonpowder(), new Stunspore(), new Strugglebug() },
			[12] = new List<Move>() { new Lightscreen() },
			[17] = new List<Move>() { new Psybeam() },
			[21] = new List<Move>() { new Supersonic() },
			[25] = new List<Move>() { new Drainingkiss() },
			[31] = new List<Move>() { new Aromatherapy() },
			[35] = new List<Move>() { new Bugbuzz() },
			[41] = new List<Move>() { new Safeguard() },
			[45] = new List<Move>() { new Quiverdance() },
			[50] = new List<Move>() { new Hurricane() },
			[55] = new List<Move>() { new Powder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Bugbite(), new Calmmind(), new Confide(), new Defog(), new Doubleteam(), new Dreameater(), new Electroweb(), new Endeavor(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Laserfocus(), new Lightscreen(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Safeguard(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Toxic(), new Uturn() };
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