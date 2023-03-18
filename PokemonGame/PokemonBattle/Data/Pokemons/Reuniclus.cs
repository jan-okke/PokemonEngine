using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Reuniclus : Pokemon
	{
		public override string Name => "Reuniclus";
		public override List<Ability> AvailableAbilities => new() {new Overcoat(), new Magicguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(110, 65, 75, 125, 85, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Hammerarm() },
			[1] = new List<Move>() { new Hammerarm(), new Protect(), new Confusion(), new Recover(), new Endeavor() },
			[12] = new List<Move>() { new Psybeam() },
			[16] = new List<Move>() { new Charm() },
			[20] = new List<Move>() { new Psyshock() },
			[24] = new List<Move>() { new Lightscreen(), new Reflect() },
			[28] = new List<Move>() { new Allyswitch() },
			[35] = new List<Move>() { new Painsplit() },
			[40] = new List<Move>() { new Psychic() },
			[48] = new List<Move>() { new Skillswap() },
			[56] = new List<Move>() { new Futuresight() },
			[64] = new List<Move>() { new Wonderroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Charm(), new Drainpunch(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Firepunch(), new Flashcannon(), new Fling(), new Focusblast(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Imprison(), new Irondefense(), new Lightscreen(), new Megapunch(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Steelroller(), new Storedpower(), new Substitute(), new Superpower(), new Thunder(), new Thunderpunch(), new Thunderwave(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 201;
		public override int ExpYield => 245;
		public override int CatchRate => 50;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}