using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mothim : Pokemon
	{
		public override string Name => "Mothim";
		public override List<Ability> AvailableAbilities => new() {new Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Tintedlens() };
		public override Stats BaseStats => new Stats(70, 94, 50, 66, 94, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Quiverdance() },
			[1] = new List<Move>() { new Quiverdance(), new Tackle(), new Protect(), new Bugbite() },
			[10] = new List<Move>() { new Protect() },
			[15] = new List<Move>() { new Bugbite() },
			[20] = new List<Move>() { new Stringshot() },
			[23] = new List<Move>() { new Confusion() },
			[26] = new List<Move>() { new Gust() },
			[29] = new List<Move>() { new Poisonpowder() },
			[32] = new List<Move>() { new Psybeam() },
			[35] = new List<Move>() { new Roost() },
			[38] = new List<Move>() { new Strugglebug() },
			[41] = new List<Move>() { new Airslash() },
			[44] = new List<Move>() { new Psychic() },
			[47] = new List<Move>() { new Lunge() },
			[50] = new List<Move>() { new Bugbuzz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Bugbite(), new Bugbuzz(), new Confide(), new Defog(), new Doubleteam(), new Dreameater(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Safeguard(), new Shadowball(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uturn(), new Venoshock() };
		public override int Weight => 233;
		public override int ExpYield => 148;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}