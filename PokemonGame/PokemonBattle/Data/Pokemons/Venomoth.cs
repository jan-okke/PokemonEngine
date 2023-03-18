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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Shielddust(), new Abilities.Tintedlens() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Wonderskin() };
		public override Stats BaseStats => new Stats(70, 65, 60, 90, 75, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Gust() },
			[1] = new List<Move>() { new Moves.Gust(), new Moves.Quiverdance(), new Moves.Bugbuzz(), new Moves.Whirlwind(), new Moves.Tackle(), new Moves.Disable(), new Moves.Strugglebug(), new Moves.Supersonic() },
			[5] = new List<Move>() { new Moves.Supersonic() },
			[11] = new List<Move>() { new Moves.Confusion() },
			[13] = new List<Move>() { new Moves.Poisonpowder() },
			[17] = new List<Move>() { new Moves.Psybeam() },
			[23] = new List<Move>() { new Moves.Stunspore() },
			[25] = new List<Move>() { new Moves.Megadrain() },
			[29] = new List<Move>() { new Moves.Sleeppowder() },
			[37] = new List<Move>() { new Moves.Leechlife() },
			[41] = new List<Move>() { new Moves.Zenheadbutt() },
			[47] = new List<Move>() { new Moves.Poisonfang() },
			[55] = new List<Move>() { new Moves.Psychic() },
			[59] = new List<Move>() { new Moves.Bugbuzz() },
			[63] = new List<Move>() { new Moves.Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Leechlife(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uturn(), new Moves.Venoshock(), new Moves.Zenheadbutt() };
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