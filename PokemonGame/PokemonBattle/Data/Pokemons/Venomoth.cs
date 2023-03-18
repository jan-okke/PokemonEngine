using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Venomoth : Pokemon
	{
		public override string Name => "Venomoth";
		public override List<Ability> AvailableAbilities => new() {new Shielddust(), new Tintedlens() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Wonderskin() };
		public override Stats BaseStats => new Stats(70, 65, 60, 90, 75, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Gust() },
			[1] = new List<Move>() { new Gust(), new Quiverdance(), new Bugbuzz(), new Whirlwind(), new Tackle(), new Disable(), new Strugglebug(), new Supersonic() },
			[5] = new List<Move>() { new Supersonic() },
			[11] = new List<Move>() { new Confusion() },
			[13] = new List<Move>() { new Poisonpowder() },
			[17] = new List<Move>() { new Psybeam() },
			[23] = new List<Move>() { new Stunspore() },
			[25] = new List<Move>() { new Megadrain() },
			[29] = new List<Move>() { new Sleeppowder() },
			[37] = new List<Move>() { new Leechlife() },
			[41] = new List<Move>() { new Zenheadbutt() },
			[47] = new List<Move>() { new Poisonfang() },
			[55] = new List<Move>() { new Psychic() },
			[59] = new List<Move>() { new Bugbuzz() },
			[63] = new List<Move>() { new Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Bugbite(), new Bugbuzz(), new Confide(), new Defog(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Leechlife(), new Protect(), new Psychic(), new Rest(), new Return(), new Roost(), new Round(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uturn(), new Venoshock(), new Zenheadbutt() };
		public override int Weight => 125;
		public override int ExpYield => 158;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}