using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mrmime : Pokemon
	{
		public override string Name => "Mr. Mime";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Soundproof(), new Abilities.Filter() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Technician() };
		public override Stats BaseStats => new Stats(40, 45, 65, 100, 120, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Quickguard(), new Moves.Wideguard(), new Moves.Powerswap(), new Moves.Guardswap(), new Moves.Pound(), new Moves.Copycat(), new Moves.Batonpass(), new Moves.Encore() },
			[12] = new List<Move>() { new Moves.Confusion() },
			[16] = new List<Move>() { new Moves.Roleplay() },
			[20] = new List<Move>() { new Moves.Protect() },
			[24] = new List<Move>() { new Moves.Recycle() },
			[28] = new List<Move>() { new Moves.Psybeam() },
			[32] = new List<Move>() { new Moves.Mimic() },
			[36] = new List<Move>() { new Moves.Lightscreen(), new Moves.Reflect(), new Moves.Safeguard() },
			[40] = new List<Move>() { new Moves.Suckerpunch() },
			[44] = new List<Move>() { new Moves.Dazzlinggleam() },
			[48] = new List<Move>() { new Moves.Psychic() },
			[52] = new List<Move>() { new Moves.Teeterdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Mistyterrain(), new Moves.Mysticalfire(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Confuseray(), new Moves.Fakeout(), new Moves.Futuresight(), new Moves.Hypnosis(), new Moves.Icywind(), new Moves.Magicroom(), new Moves.Mimic(), new Moves.Powersplit(), new Moves.Teeterdance(), new Moves.Tickle(), new Moves.Trick() };
		public override int Weight => 545;
		public override int ExpYield => 161;
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