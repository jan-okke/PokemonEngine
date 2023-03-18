using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Duosion : Pokemon
	{
		public override string Name => "Duosion";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Overcoat(), new Abilities.Magicguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
		public override Stats BaseStats => new Stats(65, 40, 50, 125, 60, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Protect(), new Moves.Confusion(), new Moves.Recover(), new Moves.Endeavor() },
			[12] = new List<Move>() { new Moves.Psybeam() },
			[16] = new List<Move>() { new Moves.Charm() },
			[20] = new List<Move>() { new Moves.Psyshock() },
			[24] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect() },
			[28] = new List<Move>() { new Moves.Allyswitch() },
			[35] = new List<Move>() { new Moves.Painsplit() },
			[40] = new List<Move>() { new Moves.Psychic() },
			[46] = new List<Move>() { new Moves.Skillswap() },
			[52] = new List<Move>() { new Moves.Futuresight() },
			[58] = new List<Move>() { new Moves.Wonderroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Futuresight(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelroller(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Thunder(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override int Weight => 80;
		public override int ExpYield => 130;
		public override int CatchRate => 100;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}